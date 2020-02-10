using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Text;

namespace XingAPINet
{
    public static class SqliteExtension
    {
        public static void UseSqlite(string sqliteFilePath)
        {
            XingClient.DBProviderFactory = SqliteFactory.Instance;
            XingClient.DBConnectionString = $"Data Source={sqliteFilePath}";

            PrepareDBTable();
        }

        private static void PrepareDBTable()
        {
            using (var connection = GetConnection())
            using (IDbTransaction tx = connection.BeginTransaction())
            {
                foreach (Type type in XingTypeList.All)
                {
                    FieldInfo blockListField = type.GetField("OutBlockTypes", BindingFlags.Public | BindingFlags.Static);
                    Type[] outBlocks = blockListField.GetValue(null) as Type[];

                    foreach (Type outBlock in outBlocks)
                    {
                        string fTypeName = outBlock.Name + ".F";
                        Type fType = type.Assembly.GetType(fTypeName);

                        StringBuilder fieldList = new StringBuilder();

                        foreach (FieldInfo field in fType.GetFields())
                        {
                            XAQueryFieldAttribute fieldInfo = field.GetCustomAttribute<XAQueryFieldAttribute>();
                            fieldList.Append($"{field.Name} {field.FieldType.ToString()} {fieldInfo.LengthOrFormat}, ");
                        }

                        string sql = $"Create Table IF NOT EXISTS {fTypeName}({fieldList.ToString()})";

                        IDbCommand cmd = connection.CreateCommand();
                        cmd.Transaction = tx;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                }

                tx.Commit();
            }
        }

        public static void WriteToDB(this XingBlock block)
        {
            using (var connection = GetConnection())
            {
                block.WriteToDB(connection);
            }
        }

        public static void WriteToDB(this XingBlock block, IDbConnection connection)
        {
            block.WriteToDB(connection, null);
        }

        public static void WriteToDB(this XingBlock block, IDbConnection connection, IDbTransaction tx)
        {
            using (IDbCommand cmd = connection.CreateCommand())
            {
                cmd.Transaction = tx;

                block.GetFieldsInfo();
            }
        }

        public static IDbConnection GetConnection()
        {
            IDbConnection connection = XingClient.DBProviderFactory.CreateConnection();
            connection.ConnectionString = XingClient.DBConnectionString;

            return connection;
        }

        public static void WriteToDB(this XingBlock[] blocks)
        {
            using (var connection = GetConnection())
            using (IDbTransaction tx = connection.BeginTransaction())
            {
                connection.Open();

                foreach (XingBlock block in blocks)
                {
                    block.WriteToDB(connection, tx);
                }

                tx.Commit();
            }
        }
    }
}

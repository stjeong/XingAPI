using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Text;
using System.Linq;

namespace XingAPINet
{
    public static class SqliteExtension
    {
        public static void UseSqlite(string sqliteFilePath)
        {
            XingClient.DBProviderFactory = SqliteFactory.Instance;
            XingClient.DBConnectionString = $"Data Source={sqliteFilePath}";
        }

        public static void PrepareAllDBTables()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (IDbTransaction tx = connection.BeginTransaction())
                {
                    foreach (Type type in XingTypeList.All)
                    {
                        FieldInfo blockListField = type.GetField("OutBlockTypes", BindingFlags.Public | BindingFlags.Static);
                        Type[] outBlocks = blockListField.GetValue(null) as Type[];

                        foreach (Type outBlock in outBlocks)
                        {
                            IDbCommand cmd = GetCreateTableCommand(outBlock);
                            cmd.Connection = connection;
                            cmd.Transaction = tx;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    tx.Commit();
                }
            }
        }

        public static string GetSqliteTypeDesc(string type, decimal fieldLen)
        {
            switch (type)
            {
                case "char":
                case "date":
                    return $"varchar({fieldLen})";

                case "long":
                case "int":
                    return "int";

                case "double":
                case "float":
                    return "real";
            }

            throw new NotSupportedException($"{type} for Sqlite");
        }

        public static IDbCommand GetDropTableCommand(this XingBlock block)
        {
            Type type = block.GetType();

            string sql = $"Drop Table IF EXISTS {type.Name}";
            IDbCommand cmd = XingClient.DBProviderFactory.CreateCommand();
            cmd.CommandText = sql;
            return cmd;
        }

        public static IDbCommand GetCreateTableCommand(this XingBlock block)
        {
            return GetCreateTableCommand(block.GetType());
        }

        public static IDbCommand GetCreateTableCommand(Type outblockType)
        {
            StringBuilder fieldList = new StringBuilder();

            foreach (FieldInfo field in outblockType.GetFields())
            {
                XAQueryFieldAttribute fieldInfo = field.GetCustomAttribute<XAQueryFieldAttribute>();
                if (fieldInfo == null)
                {
                    continue;
                }

                fieldList.Append($"{fieldInfo.UniqueName} {GetSqliteTypeDesc(fieldInfo.FieldType, fieldInfo.LengthOrFormat)},");
            }

            string sql = $"Create Table IF NOT EXISTS {outblockType.Name}({fieldList.ToString().TrimEnd(',')})";

            IDbCommand cmd = XingClient.DBProviderFactory.CreateCommand();
            cmd.CommandText = sql;
            return cmd;
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
            }
        }

        public static IDbConnection GetConnection()
        {
            IDbConnection connection = XingClient.DBProviderFactory.CreateConnection();
            connection.ConnectionString = XingClient.DBConnectionString;

            return connection;
        }

        public static void Run(this IDbCommand cmd)
        {
            using (var connection = GetConnection())
            {
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
            }
        }

        public static void WriteToDB(this XingBlock[] blocks, bool replace = true, string [] keyFields = null)
        {
            if (replace == true)
            {
                foreach (XingBlock block in blocks)
                {
                    GetDropTableCommand(block).Run();
                }

                foreach (XingBlock block in blocks)
                {
                    GetCreateTableCommand(block).Run();
                }
            }

            using (var connection = GetConnection())
            {
                connection.Open();

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
}

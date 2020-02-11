using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace XingAPINet
{
    public abstract class DatabaseExtension
    {
        public abstract string GetDatabaseTypeDesc(string type, decimal fieldLen);
        public abstract IDbCommand GetDropTableCommand(XingBlock block);

        public virtual IDbCommand GetCreateTableCommand(XingBlock block)
        {
            return GetCreateTableCommand(block.GetType());
        }

        public abstract IDbCommand GetCreateTableCommand(Type outblockType);
    }

    public static class DatabaseExtensionHelper
    {
        static DatabaseExtension _databaseExtension;
        public static DatabaseExtension DatabaseExtension { get => _databaseExtension; set => _databaseExtension = value; }

        public static void AddCandidateKeys(List<string> candidateKeys, string uniqueName)
        {
            string upperCase = uniqueName.ToUpper();
            switch (upperCase)
            {
                case "TMCODE":
                case "SHCODE":
                    candidateKeys.Add(uniqueName);
                    break;
            }
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
                            IDbCommand cmd = DatabaseExtension.GetCreateTableCommand(outBlock);
                            cmd.Connection = connection;
                            cmd.Transaction = tx;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    tx.Commit();
                }
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

                List<string> list = new List<string>();

                Type blockType = block.GetType();
                foreach (FieldInfo field in blockType.GetFields())
                {
                    XAQueryFieldAttribute fieldInfo = field.GetCustomAttributes<XAQueryFieldAttribute>();
                    if (fieldInfo == null)
                    {
                        continue;
                    }

                    IDbDataParameter dbParam = cmd.CreateParameter();
                    dbParam.ParameterName = $"@{fieldInfo.UniqueName}";
                    dbParam.Value = blockType.GetField(field.Name).GetValue(block);
                    cmd.Parameters.Add(dbParam);
                    list.Add(fieldInfo.UniqueName);
                }

                string[] fields = list.ToArray();

                string fieldList = string.Join(",", fields);
                string fieldVariables = string.Join(",", fields.Select((elem) => $"@{elem}"));

                string sql = $"INSERT INTO {blockType.Name}({fieldList}) VALUES({fieldVariables})";
                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
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
                connection.Open();

                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
            }
        }

        public static T GetCustomAttributes<T>(this FieldInfo fi) where T : Attribute
        {
            foreach (object objAttr in fi.GetCustomAttributes(false))
            {
                if (objAttr is T)
                {
                    return objAttr as T;
                }
            }

            return default;
        }

        public static void WriteToDB(this XingBlock[] blocks, bool replace = true)
        {
            if (_databaseExtension == null)
            {
                return;
            }

            if (blocks == null || blocks.Length == 0)
            {
                return;
            }

            if (replace == true)
            {
                DatabaseExtension.GetDropTableCommand(blocks[0]).Run();
                DatabaseExtension.GetCreateTableCommand(blocks[0]).Run();
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

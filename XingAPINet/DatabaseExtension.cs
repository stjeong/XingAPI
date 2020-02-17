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

        //public static void WriteToDB(this XingBlock block)
        //{
        //    using (var connection = GetConnection())
        //    {
        //        block.WriteToDB(connection);
        //    }
        //}

        //public static void WriteToDB(this XingBlock block, IDbConnection connection)
        //{
        //    block.WriteToDB(connection, null);
        //}

        public static void InsertToDB(this XingBlock block, IDbConnection connection, IDbTransaction tx)
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

        public static void WriteToDB(this XingBlock block, bool replace = true)
        {
            if (_databaseExtension == null || block == null)
            {
                return;
            }

            if (replace == true)
            {
                DatabaseExtension.GetDropTableCommand(block).Run();
                DatabaseExtension.GetCreateTableCommand(block).Run();
            }

            using (var connection = GetConnection())
            {
                connection.Open();

                using (IDbTransaction tx = connection.BeginTransaction())
                {
                    block.InsertToDB(connection, tx);
                    tx.Commit();
                }
            }
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
                    foreach (XingBlock block in blocks)
                    {
                        block.InsertToDB(connection, tx);
                    }

                    tx.Commit();
                }
            }
        }

        public static T Select<T>(this XingQuery query, QueryOption qo) where T : XingBlock, new()
        {
            if (_databaseExtension == null || query == null)
            {
                return default;
            }

            using (var connection = GetConnection())
            {
                connection.Open();

                IDbCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"SELECT * FROM {qo.TableName} {qo.WhereCondition()}";

                IDataReader dr = null;

                try
                {
                    dr = cmd.ExecuteReader();
                }
                catch (Exception)
                {
                    return default;
                }

                while (dr.Read())
                {
                    T instance = new T();

                    var fields = instance.GetFieldsInfo();
                    foreach (string key in fields.Keys)
                    {
                        object objValue = dr[key];
                        XAQueryFieldInfo xfi = fields[key];

                        xfi.SetValue(objValue);
                        instance.SetFieldValue(key, xfi);
                    }
                    return instance;
                }
            }

            return default;
        }

        public static T[] SelectMany<T>(this XingQuery query, QueryOption qo) where T : XingBlock, new()
        {
            if (_databaseExtension == null || query == null)
            {
                return default;
            }

            using (var connection = GetConnection())
            {
                connection.Open();

                IDbCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"SELECT * FROM {qo.TableName} {qo.WhereCondition()}";

                IDataReader dr = null;

                try
                {
                    dr = cmd.ExecuteReader();
                }
                catch (Exception)
                {
                    return default;
                }

                List<T> list = new List<T>();

                while (dr.Read())
                {
                    T instance = new T();

                    var fields = instance.GetFieldsInfo();
                    foreach (string key in fields.Keys)
                    {
                        object objValue = dr[key];
                        XAQueryFieldInfo xfi = fields[key];

                        xfi.SetValue(objValue);
                        instance.SetFieldValue(key, xfi);
                    }

                    list.Add(instance);
                }

                return list.ToArray();
            }
        }
    }

    public class QueryOption
    {
        readonly string _tableName;
        public string TableName => _tableName;

        readonly Dictionary<string, object> _dict = new Dictionary<string, object>();

        public QueryOption(string tableName)
        {
            _tableName = tableName;
        }

        public void Add(string name, object value)
        {
            _dict[name] = value;
        }

        public string WhereCondition()
        {
            StringBuilder sb = new StringBuilder();
            int count = _dict.Keys.Count;

            int index = 0;

            if (count != 0)
            {
                sb.Append(" WHERE ");

                foreach (string key in _dict.Keys)
                {
                    sb.Append($"{key} = {_dict[key]}");

                    if (index != count - 1)
                    {
                        sb.Append(" AND ");
                    }
                }
            }

            return sb.ToString();
        }

    }
}

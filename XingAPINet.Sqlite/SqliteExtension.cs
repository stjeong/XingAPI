using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace XingAPINet
{
    public class SqliteExtension : DatabaseExtension
    {
        public static void UseSqlite(string sqliteFilePath)
        {
            XingClient.DBProviderFactory = SqliteFactory.Instance;
            XingClient.DBConnectionString = $"Data Source={sqliteFilePath}";

            DatabaseExtensionHelper.DatabaseExtension = new SqliteExtension();
        }

        public override string GetDatabaseTypeDesc(string type, decimal fieldLen)
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

        public override IDbCommand GetDropTableCommand(XingBlock block)
        {
            Type type = block.GetType();

            string sql = $"Drop Table IF EXISTS {type.Name}";
            IDbCommand cmd = XingClient.DBProviderFactory.CreateCommand();
            cmd.CommandText = sql;
            return cmd;
        }

        public override IDbCommand GetCreateTableCommand(Type outblockType)
        {
            StringBuilder fieldList = new StringBuilder();
            string[] keyFields = null;
            List<string> candidateKeys = new List<string>();

            foreach (FieldInfo field in outblockType.GetFields())
            {
                if (field.Name == "KeyFields")
                {
                    keyFields = field.GetValue(null) as string [];
                }

                XAQueryFieldAttribute fieldInfo = field.GetCustomAttribute<XAQueryFieldAttribute>();
                if (fieldInfo == null)
                {
                    continue;
                }

                DatabaseExtensionHelper.AddCandidateKeys(candidateKeys, fieldInfo.UniqueName);
                fieldList.Append($"{fieldInfo.UniqueName} {GetDatabaseTypeDesc(fieldInfo.FieldType, fieldInfo.LengthOrFormat)},");
            }

            string sql = $"Create Table IF NOT EXISTS {outblockType.Name}({fieldList.ToString().TrimEnd(',')})";

            if (keyFields != null)
            {
                candidateKeys.Clear();
                candidateKeys.AddRange(keyFields);
            }

            foreach (string indexField in candidateKeys)
            {
                sql += $"; Create INDEX IF NOT EXISTS idx_{indexField} on {outblockType.Name}({indexField})";
            }

            IDbCommand cmd = XingClient.DBProviderFactory.CreateCommand();
            cmd.CommandText = sql;

            return cmd;
        }

    }
}

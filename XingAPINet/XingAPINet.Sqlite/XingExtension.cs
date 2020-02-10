using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Data.Common;

namespace XingAPINet
{
    public static class DBExtension
    {
        public static void UseSqlite(string sqliteFilePath)
        {
            XingClient.DBProviderFactory = SqliteFactory.Instance;
            XingClient.DBConnectionString = sqliteFilePath;
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
                cmd.Connection = connection;
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

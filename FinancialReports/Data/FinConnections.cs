using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace BangazonFinancials.Data
{
    public class FinConnections
    {
        private string _connectionString = "Data Source=C:/Users/yonatan/Documents/Visual Studio 2015/Projects/Bangazon-Financials/FinancialReports/DB/bangazon.db";

        public string connectionString { get; }

        public FinConnections()
        {
            this.connectionString = _connectionString;
        }
        public void insert(string query)
        {
            SqliteConnection dbcon = new SqliteConnection(_connectionString);

            dbcon.Open();
            SqliteCommand dbcmd = dbcon.CreateCommand();

            dbcmd.CommandText = query;
            dbcmd.ExecuteNonQuery();

            // clean up
            dbcmd.Dispose();
            dbcon.Close();
        }

        public void execute(string query, Action<SqliteDataReader> handler)
        {

            SqliteConnection dbcon = new SqliteConnection(_connectionString);

            dbcon.Open();
            SqliteCommand dbcmd = dbcon.CreateCommand();
            dbcmd.CommandText = query;

            using (var reader = dbcmd.ExecuteReader())
            {
                handler(reader);
            }

            // clean up
            dbcmd.Dispose();
            dbcon.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BangazonFinancials;
using Microsoft.Data.Sqlite;
using BangazonFinancials.Entities;
using BangazonFinancials.Data;

namespace BangazonFinancials.Factories
{
    public class FReportsFactory
    {
        public static List<Revenue> ListRevenue { get; set; } = new List<Revenue>();

        private static FinConnections _connection = new FinConnections();

        public static List<Revenue> getWeeklyReport()
        {
            FinConnections connection = _connection;
            //var d = DateTime.Today.AddDays(-7);

            var CommandText = @"SELECT 
                                ProductName, 
                                ProductRevenue, 
                                PurchaseDate
                     FROM Revenue 
                     where PurchaseDate >= Date('now', '-7 days')
                     Order by ProductName";
                     //WHERE PurchaseDate >=  + d;
                     
            connection.execute(CommandText,
            (SqliteDataReader reader) => {
                while (reader.Read())
                {
                    ListRevenue.Add(new Revenue
                    {
                        //Id = reader.GetInt32(0),
                        ProductName = reader[0].ToString(),
                        ProductRevenue = reader.GetInt32(1),
                        PurchaseDate = DateTime.Parse(reader[2].ToString()),
                    });
                }
            });
            return ListRevenue;
        }
        public static List<Revenue> getMonthlyReport()
        {
            FinConnections connection = _connection;
            //var d = DateTime.Today.AddDays(-30);

            var CommandText = @"SELECT 
                                ProductName, 
                                ProductRevenue, 
                                PurchaseDate
                     FROM Revenue 
                     where PurchaseDate >= Date('now', '-30 days')
                     Order by ProductName";
            //WHERE PurchaseDate >=  + d;

            connection.execute(CommandText,
            (SqliteDataReader reader) => {
                while (reader.Read())
                {
                    ListRevenue.Add(new Revenue
                    {
                        ProductName = reader[0].ToString(),
                        ProductRevenue = reader.GetInt32(1),
                        PurchaseDate = DateTime.Parse(reader[2].ToString()),
                    });
                }
            });
            return ListRevenue;
        }

        public static List<Revenue> getQuartlyReport()
        {
            FinConnections connection = _connection;
            //var d = DateTime.Today.AddDays(-90);

            var CommandText = @"SELECT 
                                ProductName, 
                                ProductRevenue, 
                                PurchaseDate
                     FROM Revenue 
                     where PurchaseDate >= Date('now', '-90 days')
                     Order by ProductName";
            //WHERE PurchaseDate >=  + d;

            connection.execute(CommandText,
            (SqliteDataReader reader) => {
                while (reader.Read())
                {
                    ListRevenue.Add(new Revenue
                    {
                        ProductName = reader[0].ToString(),
                        ProductRevenue = reader.GetInt32(1),
                        PurchaseDate = DateTime.Parse(reader[2].ToString()),
                    });
                }
            });
            return ListRevenue;
        }

        public static List<Revenue> getCustomerReport()
        {
            FinConnections connection = _connection;

            var CommandText = @"SELECT  CustomerFirstName || ' ' || CustomerLastName as Customer, Total(ProductRevenue) as Revenue FROM Revenue Group by Customer";

            connection.execute(CommandText,
            (SqliteDataReader reader) => {
                while (reader.Read())
                {
                    ListRevenue.Add(new Revenue
                    {
                        CustomerFirstName = reader[0].ToString(),
                        ProductRevenue = reader.GetInt32(1),
                    });
                }
            });
            return ListRevenue;
        }

        public static List<Revenue> getProductReport()
        {
            FinConnections connection = _connection;

            var CommandText = @"SELECT  ProductName as Product, 
                                        Total(ProductRevenue) as Revenue
                                FROM Revenue
                                group by ProductName";

            connection.execute(CommandText,
            (SqliteDataReader reader) => {
                while (reader.Read())
                {
                    ListRevenue.Add(new Revenue
                    {
                        ProductName = reader[0].ToString(),
                        ProductRevenue = reader.GetInt32(1),
                    });
                }
            });
            return ListRevenue;
        }


    }
}

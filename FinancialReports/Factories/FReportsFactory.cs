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
        public static List<Revenue> ListProducts { get; set; } = new List<Revenue>();

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
                    ListProducts.Add(new Revenue
                    {
                        //Id = reader.GetInt32(0),
                        ProductName = reader[0].ToString(),
                        ProductRevenue = reader.GetInt32(1),
                        PurchaseDate = DateTime.Parse(reader[2].ToString()),
                    });
                }
            });
            return ListProducts;
        }

        
    }
}

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
        // Make the factory a singleton to maintain state across all uses
        private static FReportsFactory _instance;
        public static FReportsFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FReportsFactory();
                }
                return _instance;
            }
        }
        public Revenue SingleProduct { get; set; }
        public List<Revenue> ListProducts { get; set; }

        public Revenue get(int id)
        {
            FinConnections connection = new FinConnections();

            connection.execute(@"SELECT * FROM Revenue WHERE Id = " + id,
            (SqliteDataReader reader) =>
            {
                while (reader.Read())
                {
                    SingleProduct = new Revenue
                    {
                        Id = reader.GetInt32(0),
                        ProductName = reader[1].ToString(),
                        ProductCost = reader.GetInt32(2),
                        ProductRevenue = reader.GetInt32(3),
                        ProductSupplierState = reader[4].ToString(),
                        CustomerFirstName = reader[5].ToString(),
                        CustomerLastName = reader[6].ToString(),
                        CustomerAddress = reader[7].ToString(),
                        CustomerZipCode = reader.GetInt32(8),
                        PurchaseDate = reader.GetDateTime(9)
                    };
                }
            });
            return SingleProduct;
        }
        public List<Revenue> getByDates(string startDate, string endDate)
        {
            FinConnections connection = new FinConnections();
            connection.execute($@"SELECT * FROM Revenue WHERE PurchaseDate < {endDate} & PurchaseDate > {startDate}",
                (SqliteDataReader reader) =>
                {
                    while (reader.Read())
                    {
                        SingleProduct = new Revenue
                        {
                            Id = reader.GetInt32(0),
                            ProductName = reader[1].ToString(),
                            ProductCost = reader.GetInt32(2),
                            ProductRevenue = reader.GetInt32(3),
                            ProductSupplierState = reader[4].ToString(),
                            CustomerFirstName = reader[5].ToString(),
                            CustomerLastName = reader[6].ToString(),
                            CustomerAddress = reader[7].ToString(),
                            CustomerZipCode = reader.GetInt32(8),
                            PurchaseDate = reader.GetDateTime(9)
                        };

                        ListProducts.Add(SingleProduct);
                    }
                });
            return ListProducts;
        }
    }
}


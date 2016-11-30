using BangazonFinancials.Entities;
using BangazonFinancials.Factories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;


namespace BangazonFinancials.Actions
{
    public class GetReportAction
    {
        private static List<Revenue> prods = new List<Revenue>();
        public static void GetWeeklyReport()
        {
            Console.WriteLine(@"
==========================
BANGAZON FINANCIAL REPORTS
==========================
WEEKLY REPORT
Product                                          Amount
-------------------------------------------------------");

            prods = FReportsFactory.getWeeklyReport();

            foreach (Revenue prod in prods)
            {
                Console.WriteLine("{0,-25} {1,30}", prod.ProductName, prod.ProductRevenue.ToString("C", new CultureInfo("en-US")));

            }
            Console.WriteLine("");
            Console.WriteLine("MONTHLY REPORT COMING SOON!!!");
            Console.Read();
        }
    }
}

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
            Console.WriteLine("HIT ENTER TWICE to GO TO MAIN MENU");
            Console.Read();
        }

        public static void GetMonthlyReport()
        {
            Console.WriteLine(@"
==========================
BANGAZON FINANCIAL REPORTS
==========================
MONTHLY REPORT
Product                                          Amount
-------------------------------------------------------");

            prods = FReportsFactory.getMonthlyReport();

            foreach (Revenue prod in prods)
            {
                Console.WriteLine("{0,-25} {1,30}", prod.ProductName, prod.ProductRevenue.ToString("C", new CultureInfo("en-US")));

            }
            Console.WriteLine("");
            Console.WriteLine("HIT ENTER TWICE to GO TO MAIN MENU");
            Console.Read();
        }

        public static void GetQuarterlyReport()
        {
            Console.WriteLine(@"
==========================
BANGAZON FINANCIAL REPORTS
==========================
QUARTERLY REPORT
Product                                          Amount
-------------------------------------------------------");

            prods = FReportsFactory.getQuartlyReport();

            foreach (Revenue prod in prods)
            {
                Console.WriteLine("{0,-25} {1,30}", prod.ProductName, prod.ProductRevenue.ToString("C", new CultureInfo("en-US")));

            }
            Console.WriteLine("");
            Console.WriteLine("HIT ENTER TWICE to GO TO MAIN MENU");
            Console.Read();
        }

        public static void GetCustomerReport()
        {
            Console.WriteLine(@"
==========================
BANGAZON FINANCIAL REPORTS
==========================
CUSTOMER REPORT
Product                                          Revenue
-------------------------------------------------------");

            prods = FReportsFactory.getCustomerReport();

            foreach (Revenue prod in prods)
            {
                Console.WriteLine("{0,-25} {1,30}", prod.CustomerFirstName, prod.ProductRevenue.ToString("C", new CultureInfo("en-US")));

            }
            Console.WriteLine("");
            Console.WriteLine("HIT ENTER TWICE to GO TO MAIN MENU");
            Console.Read();
        }

        public static void GetProductReport()
        {
            Console.WriteLine(@"
==========================
BANGAZON FINANCIAL REPORTS
==========================
PRODUCT REPORT
Product                                          Revenue
-------------------------------------------------------");

            prods = FReportsFactory.getProductReport();

            foreach (Revenue prod in prods)
            {
                Console.WriteLine("{0,-25} {1,30}", prod.ProductName, prod.ProductRevenue.ToString("C", new CultureInfo("en-US")));

            }
            Console.WriteLine("");
            Console.WriteLine("HIT ENTER TWICE to GO TO MAIN MENU");
            Console.Read();
        }
    }

}

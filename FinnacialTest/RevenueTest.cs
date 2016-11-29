using BangazonFinancials.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace FinnacialTest
{
    public class RevenueTest
    {
        [Fact]
        public void TestOfTesting()
        {
            bool isMonday = true;
            Assert.True(isMonday);
        }

        [Fact]
        public void CanCreateCustomer()
        {
            Revenue Rev = new Revenue
            {
                Id = 123,
                CustomerFirstName = "Bob",
                CustomerLastName = "Smith",
            };
            //per requirement user first name and last name is required
            string userFullName = Rev.CustomerFirstName + " " + Rev.CustomerLastName;
            Assert.Equal(userFullName.ToLower(), "bob smith");

            
        }
    }
}

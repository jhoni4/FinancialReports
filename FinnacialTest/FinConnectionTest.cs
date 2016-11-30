using BangazonFinancials.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace FinnacialTest
{
    public class FinConnectionTest
    {
        [Fact]
        public void DatabasePathSet()
        {
            FinConnections connection = new FinConnections();
            Assert.True(connection.connectionString.Contains(".db"));
        }
    }
}

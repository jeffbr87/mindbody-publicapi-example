using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicApiApp.Engines;
using PublicApiApp.Repositories;

namespace PublicApiAppTests
{
    [TestClass]
    public class SalesIntegrationTests
    {
        [TestMethod]
        public void GetSalesTest()
        {
            SalesEngine salesEngine = new SalesEngine();
            var startDate = DateTime.Now;
            var endDate = DateTime.Now.AddDays(1);
            salesEngine.GetSales(startDate, endDate);
        }
    }
}

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
            var startDate = DateTime.Now.Date;
            var endDate = DateTime.Now;
            salesEngine.GetSales(startDate, endDate);
        }
    }
}

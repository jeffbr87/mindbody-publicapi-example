using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicApiApp.Engines;

namespace PublicApiAppTests.Engines
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

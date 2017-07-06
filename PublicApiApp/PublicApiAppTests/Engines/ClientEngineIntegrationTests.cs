using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicApiApp.Engines;

namespace PublicApiAppTests.Engines
{
    [TestClass]
    public class ClientEngineIntegrationTests
    {
        [TestMethod]
        public void GetClientsTest()
        {
            ClientEngine clientEngine = new ClientEngine();
            clientEngine.GetClients();
        }

        [TestMethod]
        public void GetClientServicesTest()
        {
            ClientEngine clientEngine = new ClientEngine();
            var result = clientEngine.GetClientServices("100014811", DateTime.Today);
        }

        [TestMethod]
        public void GetClientScheduleTest()
        {
            ClientEngine clientEngine = new ClientEngine();
            var result = clientEngine.GetClientSchedule("100014811", DateTime.Parse("2017-02-01"));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicApiApp.Repositories;

namespace PublicApiAppTests
{
    [TestClass]
    public class ClientIntegrationTests
    {
        private static ClientRepository _clientRepository;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _clientRepository = new ClientRepository();
        }

        [TestMethod]
        public void GetClientsTest()
        {
            _clientRepository.GetClients();
        }

        [TestMethod]
        public void GetClientServicesTest()
        {
            var results = _clientRepository.GetClientServices("100014811", DateTime.Today, DateTime.Today.AddDays(30));
        }

        [TestMethod]
        public void GetClientScheduleTest()
        {
            var results = _clientRepository.GetClientSchedule("100014811", DateTime.Parse("2017-02-01"), DateTime.Parse("2017-02-27"));
        }
    }
}

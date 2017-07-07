using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicApiApp.ClientService;
using PublicApiApp.Repositories;

namespace PublicApiAppTests.Repositories
{
    [TestClass]
    public class ClientRepositoryTests
    {
        #region AddOrUpdateClients Tests

        [TestMethod]
        public void UpdateClientTest()
        {
            var clientId = "100014871";
            var randNum = new Random().Next(1, 101);
            var firstName = $"Test First {randNum}";
            var lastName = $"Test Last {randNum}";
            var email = $"volpmbotest1+{randNum}@gmail.com";

            var client = new Client
            {
                ID = clientId,
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            var clientRepository = new ClientRepository();
            var result = clientRepository.AddOrUpdateClients(client, true);

            Assert.AreEqual(firstName, result.FirstName);
            Assert.AreEqual(lastName, result.LastName);
            Assert.AreEqual(email, result.Email);
            Assert.AreEqual(ActionCode.Updated, result.Action);
        }

        [TestMethod]
        public void AddClientTest()
        {
            var randNum = new Random().Next(1, 101);
            var firstName = $"Test First {randNum}";
            var lastName = $"Test Last {randNum}";
            var email = $"volpmbotest1+{randNum}@gmail.com";

            var client = new Client
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            var clientRepository = new ClientRepository();
            var result = clientRepository.AddOrUpdateClients(client, true);

            Assert.AreEqual(firstName, result.FirstName);
            Assert.AreEqual(lastName, result.LastName);
            Assert.AreEqual(email, result.Email);
            Assert.AreEqual(ActionCode.Added, result.Action);
        }

        [TestMethod]
        public void GetClientServicesTest()
        {
            var clientRepository = new ClientRepository();
            clientRepository.GetClientServices("100014811", DateTime.Today, DateTime.Today.AddDays(30));
        }

        [TestMethod]
        public void GetClientScheduleTest()
        {
            var clientRepository = new ClientRepository();
            clientRepository.GetClientSchedule("100014811", DateTime.Parse("2017-02-01"), DateTime.Parse("2017-02-27"));
        }
        #endregion
    }
}

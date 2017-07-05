using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicApiApp.ClientService;
using PublicApiApp.Repositories;

namespace PublicApiAppTests
{
    [TestClass]
    public class ClientIntegrationTests
    {
        [TestMethod]
        public void GetClientsTest()
        {
            //TODO: start from engine
            ClientRepository clientRepository = new ClientRepository();
            clientRepository.GetClients();
        }

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

        #endregion
    }
}

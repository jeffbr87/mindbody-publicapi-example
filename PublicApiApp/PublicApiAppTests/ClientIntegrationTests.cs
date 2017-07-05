using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}

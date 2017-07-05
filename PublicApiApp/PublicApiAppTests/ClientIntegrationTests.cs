using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicApiApp.Engines;
using PublicApiApp.Repositories;

namespace PublicApiAppTests
{
    [TestClass]
    public class ClientIntegrationTests
    {
        [TestMethod]
        public void GetClientsTest()
        {
            ClientEngine clientEngine = new ClientEngine();
            clientEngine.GetClients();
        }
    }
}

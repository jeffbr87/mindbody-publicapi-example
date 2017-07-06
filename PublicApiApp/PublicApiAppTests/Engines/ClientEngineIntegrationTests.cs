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
    }
}

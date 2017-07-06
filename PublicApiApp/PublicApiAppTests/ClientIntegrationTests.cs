using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicApiApp.Engines;

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

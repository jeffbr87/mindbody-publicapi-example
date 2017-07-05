using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicApiApp.ClientService;
using PublicApiApp.Services;

namespace PublicApiApp.Repositories
{
    public class ClientRepository
    {
        public IList<ClientService.ClientService> GetClientServices(string clientId, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public IList<Visit> GetClientSchedule(string clientId, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public string AddOrUpdateClients(Client client, bool isUpdate)
        {
            throw new NotImplementedException();
        }

        public IList<Client> GetClients()
        {
            var classService = ClientServiceWrapper.GetClientService();
            var getClientsRequest = new GetClientsRequest()
            {
                SourceCredentials = classService.GetSourceCredentials(),
                UserCredentials = classService.GetOwnerCredentials(),
                XMLDetail = XMLDetailLevel.Full,
                SearchText = " "
            };
            var clientsResult = classService.GetClients(getClientsRequest);
            if(clientsResult.Status != StatusCode.Success)
                throw new Exception(clientsResult.Message);
            return clientsResult.Clients;
        }
    }
}

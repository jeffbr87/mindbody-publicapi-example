using System;
using System.Collections.Generic;
using System.Linq;
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

        public string AddOrUpdateClients(Client client)
        {
            var clientService = ClientServiceWrapper.GetClientService();
            
            var request = new AddOrUpdateClientsRequest
            {
                Clients = new[] {client},
                SendEmail = client.ID == null,
                UserCredentials = clientService.GetOwnerCredentials(),
                SourceCredentials = clientService.GetSourceCredentials()
            };

            var response = clientService.AddOrUpdateClients(request);

            if (response.ErrorCode == 200)
            {
                return response.Clients.Single().ID;
            }
            else
            {
                throw new Exception();
            }
        }

        public IList<Client> GetClients()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using PublicApiApp.ClientService;
using PublicApiApp.Exceptions;
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

        public Client AddOrUpdateClients(Client client, bool test = false)
        {
            var clientService = ClientServiceWrapper.GetClientService();
            
            var request = new AddOrUpdateClientsRequest
            {
                Clients = new[] {client},
                SendEmail = client.ID == null,
                UserCredentials = clientService.GetOwnerCredentials(),
                SourceCredentials = clientService.GetSourceCredentials(),
                Test = test
            };

            var response = clientService.AddOrUpdateClients(request);

            if (response.ErrorCode != 200)
            {
                throw new ApiException(response);
            }

            return response.Clients.Single();
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
            return clientsResult.Clients;
        }
    }
}

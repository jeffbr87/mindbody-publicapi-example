using System;
using System.Collections.Generic;
using PublicApiApp.ClientService;
using PublicApiApp.Exceptions;
using PublicApiApp.Services;

namespace PublicApiApp.Repositories
{
    public class ClientRepository
    {
        public IList<ClientService1> GetClientServices(string clientId, DateTime startDate, DateTime endDate)
        {
            var clientService = ClientServiceWrapper.GetClientService();

            var request = new GetClientServicesRequest
            {
                SourceCredentials = clientService.GetSourceCredentials(),
                UserCredentials = clientService.GetOwnerCredentials(),
                XMLDetail = XMLDetailLevel.Full,
                ClientID = clientId,
                StartDate = startDate,
                EndDate = endDate
            };

            var result = clientService.GetClientServices(request);

            if (result.Status != StatusCode.Success)
            {
                throw new ApiException(result);
            }

            return result.ClientServices;
        }

        public IList<Visit> GetClientSchedule(string clientId, DateTime startDate, DateTime endDate)
        {
            var clientService = ClientServiceWrapper.GetClientService();

            var request = new GetClientScheduleRequest
            {
                SourceCredentials = clientService.GetSourceCredentials(),
                UserCredentials = clientService.GetOwnerCredentials(),
                XMLDetail = XMLDetailLevel.Full,
                ClientID = clientId,
                StartDate = startDate,
                EndDate = endDate
            };

            var result = clientService.GetClientSchedule(request);

            if (result.Status != StatusCode.Success)
            {
                throw new ApiException(result);
            }

            return result.Visits;
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
            return clientsResult.Clients;
        }
    }
}

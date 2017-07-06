using System;
using System.Collections.Generic;
using System.Linq;
using PublicApiApp.ClientService;
using PublicApiApp.Constants;
using PublicApiApp.Helpers;
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
                EndDate = endDate,
                ProgramIDs = new [] { CTypeGroups.Classes }
            };

            var result = clientService.GetClientServices(request);

            if (result.Status != StatusCode.Success)
            {
                ErrorHelper.DisplayError(result);
                return null;
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
                ErrorHelper.DisplayError(result);
                return null;
            }

            return result.Visits;
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
                ErrorHelper.DisplayError(response);
                return null;
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

            if (clientsResult.Status != StatusCode.Success)
            {
                ErrorHelper.DisplayError(clientsResult);
                return null;
            }
            
            return clientsResult.Clients;
        }
    }
}

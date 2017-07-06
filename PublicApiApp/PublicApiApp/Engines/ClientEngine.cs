using System;
using System.Collections.Generic;
using PublicApiApp.ClientService;
using PublicApiApp.Repositories;
using PublicApiApp.Extensions;

namespace PublicApiApp.Engines
{
    public class ClientEngine
    {
        private readonly ClientRepository _clientRepository = new ClientRepository();       

        public IList<Client> GetClients()
        {
            return _clientRepository.GetClients();
        }

        public Client AddOrUpdateClient(Client client)
        {
            if (client.FirstName.IsNullOrEmpty())
            {
                throw new Exception("Client's first name cannot be empty.");
            }

            if (client.LastName.IsNullOrEmpty())
            {
                throw new Exception("Client's last name cannot be empty.");
            }

            if (client.Email.IsNullOrEmpty())
            {
                throw new Exception("Client's email cannot be empty.");
            }

            if (!client.Email.IsValidEmailAddress())
            {
                throw new Exception($"Client's email is not a valid format: {client.Email}");
            }

            if (!client.MobilePhone.IsNullOrEmpty() &&
                !client.MobilePhone.IsValidPhoneNumber())
            {
                throw new Exception($"The phone number is not in a recognized US format: {client.MobilePhone}");
            }

            return _clientRepository.AddOrUpdateClients(client);
        }

        public IList<Visit> GetClientSchedule(string clientId, DateTime startDate)
        {
            var daysInMonth = DateTime.DaysInMonth(startDate.Year, startDate.Month);
            var until = new DateTime(startDate.Year, startDate.Month, daysInMonth);
            return _clientRepository.GetClientSchedule(clientId, startDate, until);
        }

        public IList<ClientService1> GetClientServices(string clientId, DateTime startDate)
        {
            var daysInMonth = DateTime.DaysInMonth(startDate.Year, startDate.Month);
            var until = new DateTime(startDate.Year, startDate.Month, daysInMonth);
            return _clientRepository.GetClientServices(clientId, startDate, until);
        }
    }
}

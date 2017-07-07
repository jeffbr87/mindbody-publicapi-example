using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PublicApiApp.ClientService;
using PublicApiApp.Repositories;
using PublicApiApp.Extensions;
using PublicApiApp.Helpers;

namespace PublicApiApp.Engines
{
    public class ClientEngine
    {
        private readonly ClientRepository _clientRepository = new ClientRepository();

        public Task<IList<Client>> GetClientsAsync()
        {
            return new Task<IList<Client>>(GetClients);
        }

        public Task<Client> AddOrUpdateClientAsync(Client client)
        {
            return new Task<Client>(() => AddOrUpdateClient(client));
        }

        public Task<IList<Visit>> GetClientScheduleAsync(string clientId, DateTime startDate)
        {
            return new Task<IList<Visit>>(() => GetClientSchedule(clientId, startDate));
        }

        public Task<IList<ClientService1>> GetClientServicesAsync(string clientId, DateTime startDate)
        {
            return new Task<IList<ClientService1>>(() => GetClientServices(clientId, startDate));
        }

        public IList<Client> GetClients()
        {
            return _clientRepository.GetClients();
        }

        public Client AddOrUpdateClient(Client client)
        {
            if (client.FirstName.IsNullOrEmpty())
            {
                ErrorHelper.DisplayError(ErrorHelper.Severity.Error, "Client's first name cannot be empty.");
                return null;
            }

            if (client.LastName.IsNullOrEmpty())
            {
                ErrorHelper.DisplayError(ErrorHelper.Severity.Error, "Client's last name cannot be empty.");
                return null;
            }

            if (client.Email.IsNullOrEmpty())
            {
                ErrorHelper.DisplayError(ErrorHelper.Severity.Error, "Client's email cannot be empty.");
                return null;
            }

            if (!client.Email.IsValidEmailAddress())
            {
                ErrorHelper.DisplayError(ErrorHelper.Severity.Error, $"Client's email is not a valid format: {client.Email}");
                return null;
            }

            if (!client.MobilePhone.IsNullOrEmpty() &&
                !client.MobilePhone.IsValidPhoneNumber())
            {
                ErrorHelper.DisplayError(ErrorHelper.Severity.Error, $"The phone number is not in a recognized US format: {client.MobilePhone}");
                return null;
            }

            if (client.BirthDate == null || client.BirthDateSpecified == false)
            {
                ErrorHelper.DisplayError(ErrorHelper.Severity.Error, "Client's birth date is required");
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

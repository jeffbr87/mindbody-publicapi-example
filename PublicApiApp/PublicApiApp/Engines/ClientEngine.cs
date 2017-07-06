using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicApiApp.ClientService;
using PublicApiApp.Repositories;

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
            return _clientRepository.AddOrUpdateClients(client);
        }
    }
}

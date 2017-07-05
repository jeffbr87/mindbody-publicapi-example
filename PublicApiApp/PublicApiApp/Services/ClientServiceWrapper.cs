using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicApiApp.ClientService;
using PublicApiApp.Constants;

namespace PublicApiApp.Services
{
    public class ClientServiceWrapper : ClientService.ClientService
    {
        public static ClientServiceWrapper GetClientService()
        {
            return new ClientServiceWrapper {Url = CServiceEndpoints.ClientService};
        }

        public ClientService.SourceCredentials GetSourceCredentials()
        {
            return new SourceCredentials
            {
                SourceName = CCredentials.Sourcename,
                Password = CCredentials.SourcePass,
                SiteIDs = CCredentials.SiteIds
            };
        }

        public UserCredentials GetOwnerCredentials()
        {
            return new UserCredentials
            {
                Username = CCredentials.Username,
                Password = CCredentials.UserPass,
                SiteIDs = CCredentials.SiteIds
            };
        }
    }
}

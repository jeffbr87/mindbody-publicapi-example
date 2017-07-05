using PublicApiApp.SaleService;
using PublicApiApp.Constants;

namespace PublicApiApp.Services
{
    public class SaleServiceWrapper : SaleService.SaleService
    {
        public static SaleServiceWrapper GetSaleService()
        {
            return new SaleServiceWrapper { Url = CServiceEndpoints.SaleService };
        }

        public SourceCredentials GetSourceCredentials()
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

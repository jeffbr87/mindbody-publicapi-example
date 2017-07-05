using PublicApiApp.ClassService;
using PublicApiApp.Constants;

namespace PublicApiApp.Services
{
    public class ClassServiceWrapper : ClassService.ClassService
    {
        public static ClassServiceWrapper GetClassService()
        {
            return new ClassServiceWrapper { Url = CServiceEndpoints.ClassService };
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicApiApp.ClassService;
using PublicApiApp.Services;

namespace PublicApiApp.Repositories
{
    public class ClassRepository
    {
        public IList<Class> GetClasses(DateTime startDate, DateTime endDate)
        {
            var classService = ClassServiceWrapper.GetClassService();
            var getClassesRequest = new GetClassesRequest
            {
                SourceCredentials = classService.GetSourceCredentials(),
                UserCredentials = classService.GetOwnerCredentials(),
                XMLDetail = XMLDetailLevel.Full
            };

            var getClassesResults = classService.GetClasses(getClassesRequest);

            throw new NotImplementedException();
        }

        public void AddClientToClass(string clientId, int classInstanceId, int? pricingOptionId)
        {
            // No waitlisting
            throw new NotImplementedException();
        }
    }
}

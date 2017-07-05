using System;
using System.Collections.Generic;
using PublicApiApp.ClassService;
using PublicApiApp.Services;

namespace PublicApiApp.Repositories
{
    public class ClassRepository
    {
        public IList<Class> GetClasses(string clientId, DateTime startDate, DateTime endDate)
        {
            var classService = ClassServiceWrapper.GetClassService();
            var getClassesRequest = new GetClassesRequest
            {
                SourceCredentials = classService.GetSourceCredentials(),
                UserCredentials = classService.GetOwnerCredentials(),
                XMLDetail = XMLDetailLevel.Full,
                StartDateTime = startDate,
                EndDateTime = endDate,
                ClientID = clientId
            };

            var getClassesResults = classService.GetClasses(getClassesRequest);

            if (getClassesResults.ErrorCode == 200)
            {
                return getClassesResults.Classes;
            }

            return null;
        }

        public void AddClientToClass(string clientId, int classInstanceId, int? pricingOptionId)
        {
            // No waitlisting
            throw new NotImplementedException();
        }
    }
}

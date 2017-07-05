using System;
using System.Collections.Generic;
using PublicApiApp.ClassService;
using PublicApiApp.Exceptions;
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

        /// <summary>
        /// Adds a client to a class
        /// </summary>
        /// <remarks>Waitlists are not currently supported</remarks>
        /// <param name="clientId"></param>
        /// <param name="classInstanceId"></param>
        /// <param name="pricingOptionId"></param>
        public void AddClientToClass(string clientId, int classInstanceId, int? pricingOptionId)
        {
            var request = new AddClientsToClassesRequest
            {
                ClassIDs = new[] {classInstanceId},
                ClientIDs = new[] {clientId},
                ClientServiceID = pricingOptionId
            };

            AddClientsToClassesResult result;
            using (var service = ClassServiceWrapper.GetClassService())
            {
                result = service.AddClientsToClasses(request);
            }

            if (result.Status != StatusCode.Success)
            {
                throw new ApiException(result);
            }
        }
    }
}

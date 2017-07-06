using System;
using System.Collections.Generic;
using PublicApiApp.ClassService;
using PublicApiApp.Helpers;
using PublicApiApp.Services;

namespace PublicApiApp.Repositories
{
    public class ClassRepository
    {
        public IList<Class> GetClasses(string clientId, DateTime startDate, DateTime endDate)
        {
            GetClassesResult getClassesResult;
            using (var classService = ClassServiceWrapper.GetClassService())
            {
                var getClassesRequest = new GetClassesRequest
                {
                    SourceCredentials = classService.GetSourceCredentials(),
                    UserCredentials = classService.GetOwnerCredentials(),
                    XMLDetail = XMLDetailLevel.Full,
                    StartDateTime = startDate,
                    EndDateTime = endDate,
                    ClientID = clientId
                };

                getClassesResult = classService.GetClasses(getClassesRequest);
            }
                

            if (getClassesResult.ErrorCode == 200)
            {
                return getClassesResult.Classes;
            }

            ErrorHelper.DisplayError(getClassesResult);
            return null;
        }

        /// <summary>
        /// Adds a client to a class
        /// </summary>
        /// <remarks>Waitlists are not currently supported</remarks>
        public bool AddClientToClass(AddClientsToClassesRequest request)
        {
            AddClientsToClassesResult result;
            using (var service = ClassServiceWrapper.GetClassService())
            {
                // Add credentials to request payload
                request.SourceCredentials = service.GetSourceCredentials();
                request.UserCredentials = service.GetOwnerCredentials();
                
                result = service.AddClientsToClasses(request);
            }
            if (result.Status == StatusCode.Success)
            {
                return true;
            }
            ErrorHelper.DisplayError(result);
            return false;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PublicApiApp.ClassService;
using PublicApiApp.Repositories;

namespace PublicApiApp.Engines
{
    public class ClassEngine
    {
        private readonly ClassRepository _classRepository = new ClassRepository();

        public IList<Class> GetClasses(string clientId)
        {
            var now = DateTime.Now.Date;
            var daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
            var until = new DateTime(now.Year, now.Month, daysInMonth);
            return GetClasses(clientId, now, until);
        }

        public IList<Class> GetClasses(string clientId, DateTime startDate)
        {
            var daysInMonth = DateTime.DaysInMonth(startDate.Year, startDate.Month);
            var until = new DateTime(startDate.Year, startDate.Month, daysInMonth);
            return GetClasses(clientId, startDate, until);
        }

        public IList<Class> GetClasses(string clientId, DateTime startDate, DateTime endDate)
        {
            return _classRepository.GetClasses(clientId, startDate, endDate).Where(c => !c.IsEnrolled).ToList();
        }

        /// <summary>
        /// Add a client to a class
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="classInstanceId"></param>
        /// <param name="pricingOptionId">If a pricing option is not specified, the API will choose one</param>
        /// <returns>Boolean representing success/failure</returns>
        public bool AddClientToClass(string clientId, int classInstanceId, int? pricingOptionId)
        {
            return _classRepository.AddClientToClass(new AddClientsToClassesRequest
            {
                ClassIDs = new[] { classInstanceId },
                ClientIDs = new[] { clientId },
                ClientServiceID = pricingOptionId
            });
        }
    }
}

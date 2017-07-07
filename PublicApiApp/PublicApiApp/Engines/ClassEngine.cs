using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PublicApiApp.ClassService;
using PublicApiApp.Helpers;
using PublicApiApp.Repositories;

namespace PublicApiApp.Engines
{
    public class ClassEngine
    {
        private readonly ClassRepository _classRepository = new ClassRepository();

        public Task<IList<Class>> GetClassesAsync(string clientId)
        {
            return new Task<IList<Class>>(() => GetClasses(clientId));
        }

        public Task<IList<Class>> GetClassesAsync(string clientId, DateTime startDate)
        {
            return new Task<IList<Class>>(() => GetClasses(clientId, startDate));
        }

        public Task<bool> AddClientToClassAsync(string clientId, int classId, long? clientServiceId)
        {
            return new Task<bool>(() => AddClientToClass(clientId, classId, clientServiceId));
        }

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

        private IList<Class> GetClasses(string clientId, DateTime startDate, DateTime endDate)
        {
            return _classRepository.GetClasses(clientId, startDate, endDate)
                .Where(c => !c.IsEnrolled && c.IsAvailable.GetValueOrDefault() && c.MaxCapacity > c.TotalBooked)
                .ToList();
        }

        /// <summary>
        /// Adds a client to a class
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="classId"></param>
        /// <param name="clientServiceId">Optional. If not specified, the API will select the service pricing option to use</param>
        /// <returns></returns>
        public bool AddClientToClass(string clientId, int classId, long? clientServiceId)
        {
            if (string.IsNullOrWhiteSpace(clientId))
            {
                ErrorHelper.DisplayError(ErrorHelper.Severity.Error, "An unknown error occurred. Please re-select the client.");
                return false;
            }

            // For whatever reason, get client services gives client service IDs that are nullable longs,
            // and add client to class takes nullable ints. HOT DERPAGE
            int? clientServiceIdInt;
            try
            {
                clientServiceIdInt = clientServiceId.HasValue ? Convert.ToInt32(clientServiceId) : (int?) null;
            }
            catch (OverflowException)
            {
                clientServiceIdInt = null;
            }

            return _classRepository.AddClientToClass(new AddClientsToClassesRequest
            {
                ClientIDs = new[] {clientId},
                ClassIDs = new[] {classId},
                ClientServiceID = clientServiceIdInt
            });
        }
    }
}

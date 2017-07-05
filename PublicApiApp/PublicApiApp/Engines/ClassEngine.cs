using System;
using System.Collections;
using System.Collections.Generic;
using PublicApiApp.ClassService;
using PublicApiApp.Repositories;

namespace PublicApiApp.Engines
{
    public class ClassEngine
    {
        public IList<Class> GetClasses(string clientId)
        {
            var now = DateTime.Now.Date;
            var daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
            var until = new DateTime(now.Year, now.Month, daysInMonth);
            return GetClasses(clientId, now, until);
        }

        public IList<Class> GetClasses(string clientId, DateTime startDate, DateTime endDate)
        {
            var repository = new ClassRepository();
            return repository.GetClasses(clientId, startDate, endDate);
        }
    }
}

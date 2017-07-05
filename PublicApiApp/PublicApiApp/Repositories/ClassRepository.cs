using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicApiApp.ClassService;

namespace PublicApiApp.Repositories
{
    public class ClassRepository
    {
        public IList<Class> GetClasses(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public void AddClientToClass(string clientId, int classInstanceId, int? pricingOptionId)
        {
            // No waitlisting
            throw new NotImplementedException();
        }
    }
}

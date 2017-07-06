using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicApiApp.Repositories;
using PublicApiApp.SaleService;

namespace PublicApiApp.Engines
{
    public class SalesEngine
    {
        private readonly SalesRepository _salesRepository = new SalesRepository();

        public IList<Sale> GetSales(DateTime startDate, DateTime endDate)
        {
            return _salesRepository.GetSales(startDate, endDate);
        }
    }
}

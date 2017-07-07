using System;
using System.Collections.Generic;
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

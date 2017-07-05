using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicApiApp.SaleService;
using PublicApiApp.Services;

namespace PublicApiApp.Repositories
{
    public class SalesRepository
    {
        public IList<Sale> GetSales(DateTime startDate, DateTime endDate)
        {
            var salesService = SaleServiceWrapper.GetSaleService();
            var getSalesRequest = new GetSalesRequest
            {
                SourceCredentials = salesService.GetSourceCredentials(),
                UserCredentials = salesService.GetOwnerCredentials(),
                XMLDetail = XMLDetailLevel.Full
            };

            var salesResult = salesService.GetSales(getSalesRequest);
            if (salesResult.Status != StatusCode.Success)
                throw new Exception(salesResult.Message);
            return null;
        }
    }
}

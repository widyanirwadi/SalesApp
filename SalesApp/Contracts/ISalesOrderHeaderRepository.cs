using SalesApp.Models;

namespace SalesApp.Contracts
{
    public interface ISalesOrderHeaderRepository
    {
        public Task<IEnumerable<SalesOrderHeader>> GetSalesOrderHeaderBySalesOrderID(int salesOrderId);
    }
}

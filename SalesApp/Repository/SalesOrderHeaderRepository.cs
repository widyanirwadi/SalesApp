using Dapper;
using SalesApp.Context;
using SalesApp.Contracts;
using SalesApp.Models;
using System.Data;

namespace SalesApp.Repository
{
    public class SalesOrderHeaderRepository : ISalesOrderHeaderRepository
    {
        public readonly DbContext _dbContext;
        
        public SalesOrderHeaderRepository(DbContext context)
        {
            _dbContext = context;
        }

        public async Task<IEnumerable<SalesOrderHeader>> GetSalesOrderHeaderBySalesOrderID (int salesOrderID)
        {
            using (IDbConnection connection = _dbContext.CreateConnection())
            {
                const string storedProcedure = "dbo.GetSalesOrderHeaderBySalesOrderID";
                return await connection.QueryAsync<SalesOrderHeader>(storedProcedure,
                    new
                    {
                        salesOrderID
                    },
                        commandType: CommandType.StoredProcedure);
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SalesApp.Contracts;
using SalesApp.Models;

namespace SalesApp.Controllers
{
    [ApiController]
    [Route("SalesOrderHeader")]
    public class SalesOrderHeaderController : Controller
    {
        public readonly ISalesOrderHeaderRepository _SalesOrderHeaderRepository;

        public SalesOrderHeaderController (ISalesOrderHeaderRepository salesOrderHeaderRepository)
        {
            _SalesOrderHeaderRepository = salesOrderHeaderRepository;
        }

        [HttpGet("GetSalesOrderHeaderBySalesOrderID")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<SalesOrderHeader>))]
        public async Task<IActionResult> GetSalesOrderHeaderBySalesOrderID (int salesOrderID)
        {
            IEnumerable<SalesOrderHeader> salesOrderHeaders = await _SalesOrderHeaderRepository.GetSalesOrderHeaderBySalesOrderID(salesOrderID);
            return Ok(salesOrderHeaders);
        }
    }
}

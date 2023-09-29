using Business.Services;
using Business.Services.Entities;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/invoices")]
    [ApiController]
    public class InvoicesController : BaseController<Invoice, InvoiceDto>
    {
        private readonly InvoiceService _invoiceService;
        public InvoicesController(GenericService<Invoice> service, InvoiceService invoiceService) : base(service)
        {
            _invoiceService = invoiceService;
        }
        [HttpGet("orderHasInvoice/{orderId}")]
        public async Task<bool> GetOrderTotal(int orderId)
        {
            return await _invoiceService.OrderHasInvoiceAsync(orderId);
        }
    }
}

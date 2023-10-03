using Business.Services;
using Business.Services.Entities;
using Contracts.DTOs.Entities;
using Contracts.Utils;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/invoices")]
    [ApiController]
    public class InvoicesController : BaseController<Invoice, InvoiceDto>
    {
        private readonly InvoiceService _invoiceService;
        public InvoicesController(InvoiceService service) : base(service)
        {
            _invoiceService = service;
        }
        [HttpPost]
        public override async Task<IActionResult> CreateAsync([FromBody] InvoiceDto dto)
        {
            try
            {
                var createdEntity = await _service.CreateAsync(DtoMapper.CreateEntityFromDto<Invoice>(dto));
                return Ok(createdEntity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message} \nInner Exception: {ex.InnerException}");
            }
        }
        [HttpGet("orderHasInvoice/{orderId}")]
        public async Task<bool> OrderHasInvoice(int orderId)
        {
            return await _invoiceService.OrderHasInvoiceAsync(orderId);
        }
    }
}

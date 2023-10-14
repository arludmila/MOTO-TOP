using Business.Services;
using Business.Services.Entities;
using Contracts.DTOs.Entities;
using Contracts.Utils;
using Contracts.ViewModels;
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
        [HttpPost("detailed")]
        public async Task<Invoice> CreateInvoiceCentralAsync(InvoiceWithDetailsDto dto)
        {
            return await _invoiceService.CreateInvoiceCentralAsync(dto);
        }
        [HttpGet("view-models")]
        public async Task<List<InvoiceViewModel>> GetAllVMAsync()
        {
            return await _invoiceService.GetAllVMAsync();
        }
        [HttpPost]
        public override async Task<IActionResult> CreateAsync([FromBody] InvoiceDto dto)
        {
            try
            {
                var createdEntity = await _invoiceService.CreateInvoiceAsync(DtoMapper.CreateEntityFromDto<Invoice>(dto));
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

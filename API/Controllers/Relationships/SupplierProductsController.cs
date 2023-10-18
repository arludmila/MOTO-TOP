using Business.Services;
using Business.Services.Entities;
using Business.Services.Relationships;
using Contracts.DTOs.Entities;
using Contracts.DTOs.Relationships;
using Contracts.Utils;
using Entities.Core;
using Entities.Relationships;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Relationships
{
    [Route("api/supplier-products")]
    [ApiController]
    public class SupplierProductsController : BaseController<SupplierProduct, SupplierProductDto, int>
    {
        private readonly SupplierProductService _supplierProductService;
        public SupplierProductsController(SupplierProductService service) : base(service)
        {
            _supplierProductService = service;
        }
        [HttpPost]
        public override async Task<IActionResult> CreateAsync([FromBody] SupplierProductDto dto)
        {
            try
            {
                var createdEntity = await _supplierProductService.CreateSuppProdAsync(DtoMapper.CreateEntityFromDto<SupplierProduct>(dto));
                return Ok(createdEntity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message} \nInner Exception: {ex.InnerException}");
            }
        }
    }
}

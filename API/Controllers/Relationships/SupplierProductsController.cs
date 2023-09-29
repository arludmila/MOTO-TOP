using Business.Services;
using Contracts.DTOs.Relationships;
using Entities.Relationships;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Relationships
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierProductsController : BaseController<SupplierProduct, SupplierProductDto>
    {
        public SupplierProductsController(GenericService<SupplierProduct> service)
            : base(service)
        {
        }
    }
}

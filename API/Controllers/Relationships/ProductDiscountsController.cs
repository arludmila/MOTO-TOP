using Business;
using Contracts.DTOs.Relationships;
using Entities.Relationships;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Relationships
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDiscountsController : BaseController<ProductDiscount, ProductDiscountDto>
    {
        public ProductDiscountsController(GenericService<ProductDiscount> service)
            : base(service)
        {
        }
    }
}

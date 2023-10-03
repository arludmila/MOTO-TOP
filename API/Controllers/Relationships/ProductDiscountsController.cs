using Business.Services;
using Contracts.DTOs.Relationships;
using Entities.Relationships;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Relationships
{
    [Route("api/product-discounts")]
    [ApiController]
    public class ProductDiscountsController : BaseController<ProductDiscount, ProductDiscountDto>
    {
        public ProductDiscountsController(GenericService<ProductDiscount> service)
            : base(service)
        {
        }
    }
}

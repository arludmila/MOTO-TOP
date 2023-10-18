using Business.Services;
using Contracts.DTOs.Relationships;
using Entities.Relationships;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Relationships
{
    [Route("api/product-discounts")]
    [ApiController]
    public class ProductDiscountsController : BaseController<ProductDiscount, ProductDiscountDto, int>
    {
        public ProductDiscountsController(GenericService<ProductDiscount, int> service)
            : base(service)
        {
        }
    }
}

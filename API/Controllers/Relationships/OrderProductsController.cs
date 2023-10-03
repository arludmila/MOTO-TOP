using Business.Services;
using Contracts.DTOs.Relationships;
using Entities.Relationships;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Relationships
{
    [Route("api/order-products")]
    [ApiController]
    public class OrderProductsController : BaseController<OrderProduct, OrderProductDto>
    {
        public OrderProductsController(GenericService<OrderProduct> service)
            : base(service)
        {
        }
    }
}

using Business.Services;
using Contracts.DTOs.Relationships;
using Entities.Relationships;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Relationships
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderProductsController : BaseController<OrderProduct, OrderProductDto>
    {
        public OrderProductsController(GenericService<OrderProduct> service)
            : base(service)
        {
        }
    }
}

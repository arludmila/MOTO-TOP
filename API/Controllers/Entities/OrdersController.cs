using Business;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : BaseController<Order, OrderDto>
    {
        public OrdersController(GenericService<Order> service) : base(service)
        {
        }
    }
}

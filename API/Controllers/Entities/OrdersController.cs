using Business.Services;
using Business.Services.Entities;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    // TODO: cambiar rutas a minuscula!!!
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : BaseController<Order, OrderDto>
    {
        private readonly OrderService _orderService;
        public OrdersController(OrderService service) : base(service)
        {
            _orderService = service;
        }
        [HttpGet("getOrderTotal/{orderId}")]
        public async Task<double> GetOrderTotal(int orderId)
        {
            return await _orderService.GetOrderTotalAsync(orderId);
        }
    }
}

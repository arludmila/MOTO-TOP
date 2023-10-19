using Business.Services.Entities;
using Contracts.DTOs.Entities;
using Contracts.Utils;
using Contracts.ViewModels;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    // TODO: cambiar rutas a minuscula!!!
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : BaseController<Order, OrderDto, Guid>
    {
        private readonly OrderService _orderService;
        public OrdersController(OrderService service) : base(service)
        {
            _orderService = service;
        }
        [HttpPost]
        public override async Task<IActionResult> CreateAsync([FromBody] OrderDto dto)
        {
            try
            {
                dto.Date = DateTime.Now;
                var createdEntity = await base.CreateAsync(dto);
                return Ok(createdEntity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message} \nInner Exception: {ex.InnerException}");
            }
        }
        [HttpGet("view-models")]
        public async Task<List<OrderViewModel>> GetAll()
        {
            return await _orderService.GetAllAsync();
        }
        [HttpGet("view-models/{id}")]
        public async Task<OrderViewModel> GetById(Guid id)
        {
            return await _orderService.GetByIdAsync(id);
        }
        [HttpGet("getOrderTotal/{orderId}")]
        public async Task<double> GetOrderTotal(Guid orderId)
        {
            return await _orderService.GetOrderTotalAsync(orderId);
        }
        [HttpGet("getOrderStatus/{orderId}")]
        public async Task<string> GetOrderStatus(Guid orderId)
        {
            return (await _orderService.GetOrderStatusAsync(orderId)).ToString();
        }
    }
}
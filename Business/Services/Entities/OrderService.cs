using Contracts.DTOs.Entities;
using Contracts.ViewModels;
using Data.Repositories;
using Data.Repositories.Entities;
using Entities.Core;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace Business.Services.Entities
{
    public class OrderService : GenericService<Order, Guid>
    {
        private readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository repository) : base(repository)
        {
            _orderRepository = repository;
        }
        public async Task<List<OrderViewModel>> GetAllAsync()
        {
            return await _orderRepository.GetAllAsync();
        }
        public async Task<OrderViewModel> GetByIdAsync(Guid id)
        {
            return await _orderRepository.GetByIdAsync(id);
        }
        public async Task<double> GetOrderTotalAsync(Guid id)
        {
            return await _orderRepository.GetOrderTotalAsync(id);
        }
        public async Task<ShipmentStatuses> GetOrderStatusAsync(Guid id)
        {
            return await _orderRepository.GetOrderStatusAsync(id);
        }
        public async Task<Order> CreateDetailedOrderAsync(OrderWithDetailsDto dto)
        {
            return await _orderRepository.CreateDetailedOrderAsync(dto);
        }
        public async Task<List<OrderViewModel>> GetSellerOrdersAsync(int id)
        {
            return await _orderRepository.GetSellerOrdersAsync(id);
        }
    }
}

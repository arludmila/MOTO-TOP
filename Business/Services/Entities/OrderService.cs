using Data.Repositories;
using Data.Repositories.Entities;
using Entities.Core;

namespace Business.Services.Entities
{
    public class OrderService : GenericService<Order>
    {
        private readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository repository) : base(repository)
        {
            _orderRepository = repository;
        }

        public async Task<double> GetOrderTotalAsync(int id)
        {
            return await _orderRepository.GetOrderTotalAsync(id);
        }
    }
}

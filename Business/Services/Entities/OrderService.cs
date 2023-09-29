using Data.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Entities
{
    public class OrderService
    {
        private readonly OrderRepository _repository;
        public OrderService(OrderRepository repository)
        {
            _repository = repository;
        }
        public async Task<double> GetOrderTotalAsync(int id)
        {
            return await _repository.GetOrderTotalAsync(id);
        }
    }
}

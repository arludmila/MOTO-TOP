using Contracts.DTOs.Entities;
using Contracts.DTOs.Relationships;
using Data.Repositories;
using Entities.Core;
using Entities.Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Relationships
{
    public class OrderProductService : GenericService<OrderProduct, OrderProductDto, int>
    {
        private readonly GenericRepository<OrderProduct, int> _repository;

        public OrderProductService(GenericRepository<OrderProduct, int> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}

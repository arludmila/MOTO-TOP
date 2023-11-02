using Contracts.DTOs.Entities;
using Data.Repositories;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Entities
{
    public class DiscountService : GenericService<Discount, DiscountDto, int>
    {
        private readonly GenericRepository<Discount, int> _repository;

        public DiscountService(GenericRepository<Discount, int> repository) : base(repository)
        {
            _repository = repository;
        }
    
    }
}

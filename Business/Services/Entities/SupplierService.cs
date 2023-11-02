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
    public class SupplierService : GenericService<Supplier, SupplierDto, int>
    {
        private readonly GenericRepository<Supplier, int> _repository;

        public SupplierService(GenericRepository<Supplier, int> repository) : base(repository)
        {
            _repository = repository;
        }
    
    
    }
}

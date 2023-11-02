using Contracts.DTOs.Relationships;
using Contracts.Utils;
using Data.Repositories.Entities;
using Data.Repositories.Relationships;
using Entities.Core;
using Entities.Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Relationships
{
    public class SupplierProductService : GenericService<SupplierProduct, SupplierProductDto, int>
    {
        private readonly SupplierProductRepository _supplierProductRepository;

        public SupplierProductService(SupplierProductRepository repository) : base(repository)
        {
            _supplierProductRepository = repository;
        }
        public async Task<SupplierProduct> CreateSuppProdAsync(SupplierProductDto dto)
        {
            return await _supplierProductRepository.CreateSuppProdAsync(DtoMapper.CreateEntityFromDto<SupplierProduct>(dto));
        }
    }
}

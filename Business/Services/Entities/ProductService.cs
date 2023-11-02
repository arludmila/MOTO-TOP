using Contracts.DTOs.Entities;
using Contracts.ViewModels;
using Data.Repositories.Entities;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Entities
{
    public class ProductService : GenericService<Product, ProductDto, int>
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository repository) : base(repository)
        {
            _productRepository = repository;
        }
        public async Task<List<ProductViewModel>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }
        }
}

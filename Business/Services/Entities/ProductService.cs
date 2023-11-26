using Contracts.ViewModels;
using Data.Repositories.Entities;
using Entities.Core;

namespace Business.Services.Entities
{
    public class ProductService : GenericService<Product, int>
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
        public async Task<List<DiscountedProductViewModel>> GetAllDiscountedProductsAsync()
        {
            return await _productRepository.GetAllDiscountedProductsAsync();
        }

    }
}

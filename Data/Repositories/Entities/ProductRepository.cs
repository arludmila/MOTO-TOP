using Contracts.ViewModels;
using Entities.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Entities
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(MotoTopContext context) : base(context)
        {

        }
        public async Task<List<ProductViewModel>> GetAllAsync()
        {

            var products = await _context.Set<Product>().Include(x => x.Category).ToListAsync();
            List<ProductViewModel> result = new List<ProductViewModel>();
            foreach (var product in products)
            {
                var productVM = new ProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    SellingPrice = product.SellingPrice,
                    PurchasePrice = product.PurchasePrice,
                    Quantity = product.Quantity,
                    CategoryName = product.Category.Name
                };
                result.Add(productVM);
            }
            return result;
        }
    }
}

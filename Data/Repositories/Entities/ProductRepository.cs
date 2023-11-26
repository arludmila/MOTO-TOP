using Contracts.ViewModels;
using Entities.Core;
using Entities.Relationships;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Entities
{
    public class ProductRepository : GenericRepository<Product, int>
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
        public async Task<List<DiscountedProductViewModel>> GetAllDiscountedProductsAsync()
        {
            var productDiscounts = await _context.Set<ProductDiscount>()
                .Where(pd => pd.DateStart <= DateTime.Now && pd.DateEnd >= DateTime.Now)
                .Include(pd => pd.Product)
                    .ThenInclude(p => p.Category)
                .Include(pd => pd.Discount)
                .ToListAsync();
            var result = new List<DiscountedProductViewModel>();
            foreach (var pd in productDiscounts)
            {
                var dpVM = new DiscountedProductViewModel()
                {
                    Id = pd.ProductId,
                    Name = pd.Product.Name,
                    Description = pd.Product.Description,
                    CategoryName = pd.Product.Category.Name,
                    Quantity = pd.Product.Quantity,
                    OriginalPrice = pd.Product.SellingPrice,
                    DiscountPercentage = pd.Discount.Percentage,
                    DateStart = pd.DateEnd,
                    DateEnd = pd.DateStart,
                    DiscountAmount = pd.Product.SellingPrice * pd.Discount.Percentage,
                    DiscountedPrice = pd.Product.SellingPrice - pd.Product.SellingPrice * pd.Discount.Percentage,
                    ImagePath = pd.Product.ImagePath
            };

                //if (dpVM.ImagePath != null)
                //{
                //    dpVM.ImagePath = pd.Product.ImagePath;
                //}


                result.Add(dpVM);
            }
            return result;
        }
    }
}

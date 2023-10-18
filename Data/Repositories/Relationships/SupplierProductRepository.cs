using Entities.Core;
using Entities.Relationships;

namespace Data.Repositories.Relationships
{
    public class SupplierProductRepository : GenericRepository<SupplierProduct, int>
    {
        public SupplierProductRepository(MotoTopContext context) : base(context)
        {

        }

        public async Task<SupplierProduct> CreateSuppProdAsync(SupplierProduct supplierProduct)
        {
            _context.Set<SupplierProduct>().Add(supplierProduct);
            var product = _context.Set<Product>().FirstOrDefault(x => x.Id == supplierProduct.ProductId);
            if (product != null)
            {
                product.Quantity += supplierProduct.Quantity;
                product.PurchasePrice = supplierProduct.PurchasePrice;
                product.SellingPrice = supplierProduct.SellingPrice;
            }
            await _context.SaveChangesAsync();
            return supplierProduct;
        }
    }
}

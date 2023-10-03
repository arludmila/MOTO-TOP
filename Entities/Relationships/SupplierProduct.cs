using Entities.Core;

namespace Entities.Relationships
{
    public class SupplierProduct
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
    }
}

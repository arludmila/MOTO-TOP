using Entities.Core;

namespace Entities.Relationships
{
    public class SupplierProduct
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
    }
}

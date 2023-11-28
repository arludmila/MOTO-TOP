using Entities.Core;

namespace Entities.Relationships
{
    public class ProductDiscount
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int ProductId { get; set; }
        public int DiscountId { get; set; }
        public Product Product { get; set; }
        public Discount Discount { get; set; }

    }
}

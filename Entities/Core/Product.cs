namespace Entities.Core
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public double PurchasePrice { get; set; }
        public double SellingPrice { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

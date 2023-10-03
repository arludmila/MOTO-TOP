namespace Contracts.DTOs.Relationships
{
    public class SupplierProductDto
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}

namespace Contracts.DTOs.Relationships
{
    public class ProductDiscountDto
    {
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int ProductId { get; set; }
        public int DiscountId { get; set; }
    }
}

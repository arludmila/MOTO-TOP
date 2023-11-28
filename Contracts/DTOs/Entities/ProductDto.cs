using Contracts.Utils;
using Entities.Core;

namespace Contracts.DTOs.Entities
{
    public class ProductDto
    {
        public string Name { get; set; }
        public double PurchasePrice { get; set; }
        public double SellingPrice { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public string? ImagePath { get; set; }
    }
}

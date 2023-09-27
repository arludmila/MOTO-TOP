using Entities.Core;

namespace Entities.Relationships
{
    public class SellerClient
    {
        public int SellerId { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;
        public Seller Seller { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}

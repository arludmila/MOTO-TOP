using Entities.Enums;
using Entities.Relationships;

namespace Entities.Core
{
    public class Order
    {
        public Guid Id { get; set; }
        public ShipmentStatuses ShipmentStatus { get; set; }
        public DateTime DateSent { get; set; }
        public DateTime DateReceived { get; set; }
        public int ClientId { get; set; }
        public int SellerId { get; set; }
        public int TransportCompanyId { get; set; }
        public bool HasInvoice { get; set; }
        public TransportCompany TransportCompany { get; set; }
        public Client Client { get; set; }
        public Seller Seller { get; set; }
        public List<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    }
}

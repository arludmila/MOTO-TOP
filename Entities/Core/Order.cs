using Entities.Enums;

namespace Entities.Core
{
    public class Order : EntityBase
    {
        public ShipmentStatuses ShipmentStatus { get; set; }
        public DateTime DateSent { get; set; }
        public DateTime DateReceived { get; set; }
        public int ClientId { get; set; }
        public int SellerId { get; set; }
        public int? TransportCompanyId { get; set; }
        public TransportCompany? TransportCompany { get; set; }
        public Client Client { get; set; }
        public Seller Seller { get; set; }

    }
}

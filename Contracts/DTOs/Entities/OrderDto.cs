using Entities.Enums;

namespace Contracts.DTOs.Entities
{
    public class OrderDto
    {
        public ShipmentStatuses ShipmentStatus { get; set; }
        public DateTime DateSent { get; set; }
        public DateTime DateReceived { get; set; }
        public int ClientId { get; set; }
        public int SellerId { get; set; }
        public int? TransportCompanyId { get; set; }

    }
}

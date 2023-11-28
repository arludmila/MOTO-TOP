using Entities.Enums;

namespace Contracts.DTOs.Entities
{
    public class OrderDto
    {
        public DateTime Date { get; set; }
        public int ClientId { get; set; }
        public int SellerId { get; set; }
        public int? TransportCompanyId { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? DateReceived { get; set; }
        public ShipmentStatuses? ShipmentStatus { get; set; }
    }
}

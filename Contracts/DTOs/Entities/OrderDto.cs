using Entities.Enums;

namespace Contracts.DTOs.Entities
{
    public class OrderDto
    {
        public int ClientId { get; set; }
        public int SellerId { get; set; }
        public int TransportCompanyId { get; set; }

    }
}

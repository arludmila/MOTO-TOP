using Contracts.Utils;
using Entities.Core;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTOs
{
    public class OrderDto
    {
        public ShipmentStatus ShipmentStatus { get; set; }
        public DateTime DateSent { get; set; }
        public DateTime DateReceived { get; set; }
        public int ClientId { get; set; }
        public int SellerId { get; set; }
        public int? TransportCompanyId { get; set; }

        public static Order Convert(OrderDto dto)
        {
            return DtoMapper.CreateEntityFromDto<Order>(dto);
        }
    }
}

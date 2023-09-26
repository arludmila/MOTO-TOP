using Contracts.Utils;
using Entities.Core;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;

namespace Entities.Core
{
    public class Order
    {
        public int Id { get; set; }
        public ShipmentStatus ShipmentStatus { get; set; }
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

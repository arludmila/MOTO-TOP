














using Entities.Enums;
using Entities.Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ViewModels
{
    public class OrderViewModel
    {
        public Guid Id { get; set; }
        public string ShipmentStatus { get; set; }
        public string ClientName { get; set; }
        public string SellerName { get; set; }
        public string TransportCompanyName { get; set; }
        public DateTime DateSent { get; set; }
        public DateTime DateReceived { get; set; }
        public bool HasInvoice { get; set; }
        // testing...
        public List<OrderProductViewModel> OrderProducts { get; set; } = new List<OrderProductViewModel>();
    }
}
















using Entities.Enums;
using Entities.Relationships;
using OfficeOpenXml.Attributes;
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
        public DateTime Date { get; set; }
        public string ShipmentStatus { get; set; }
        public string ClientName { get; set; }
        public string SellerName { get; set; }
        [EpplusIgnore]
        public string TransportCompanyName { get; set; }
        [EpplusIgnore]
        public DateTime DateSent { get; set; }
        [EpplusIgnore]
        public DateTime DateReceived { get; set; }
        [EpplusIgnore]
        public bool HasInvoice { get; set; }
        [EpplusIgnore]
        // testing...
        public List<OrderProductViewModel> OrderProducts { get; set; } = new List<OrderProductViewModel>();
    }
}

using Entities.Core;
using OfficeOpenXml.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ViewModels
{
    public class InvoiceViewModel
    {
        public int Id { get; set; }
        public Guid? OrderId { get; set; }
        public string? SellerName { get; set; }
        public int ClientId { get; set; }
        public string ClientDocument { get; set; }
        public string ClientName { get; set; }
        
        public DateTime Date { get; set; }
        public double TotalAmount { get; set; }
        public double DebtAmount { get; set; }
        [EpplusIgnore]
        // testing...
        public List<OrderProductViewModel>? InvoiceDetails { get; set; } = new List<OrderProductViewModel>();

    }
}

using Entities.Core;
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
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public double TotalAmount { get; set; }
        public double DebtAmount { get; set; }
    }
}

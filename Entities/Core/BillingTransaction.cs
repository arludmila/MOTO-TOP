using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Core
{
    public class BillingTransaction
    {
        public int Id { get; set; }
        public string MyProperty { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
        // debito -> + (positivo) ; credito -> - (negativo)
        public double Amount { get; set; }
        public string DocumentType { get; set; }
        public int DocumentNumber { get; set; }
        public int InvoiceId { get; set; }
        public int ClientId { get; set; }
        public Invoice Invoice { get; set; }
        public Client Client { get; set; }

    }
}

using Entities.Core;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ViewModels
{
    public class BillingTransactionViewModel
    {
        public int Id { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
        // debito -> + (positivo) ; credito -> - (negativo)
        public double Amount { get; set; }
        public string DocumentType { get; set; }
        public int DocumentNumber { get; set; }
        public int InvoiceId { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
    }
}

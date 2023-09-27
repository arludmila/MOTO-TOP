using Entities.Enums;

namespace Entities.Core
{
    public class BillingTransaction : EntityBase
    {
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

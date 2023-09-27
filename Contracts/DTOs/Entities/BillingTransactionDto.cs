using Entities.Enums;

namespace Contracts.DTOs.Entities
{
    public class BillingTransactionDto
    {
        public PaymentMethods PaymentMethod { get; set; }
        // debito -> + (positivo) ; credito -> - (negativo)
        public double Amount { get; set; }
        public string DocumentType { get; set; }
        public int DocumentNumber { get; set; }
        public int InvoiceId { get; set; }
        public int ClientId { get; set; }

    }
}

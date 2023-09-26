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
    public class BillingTransactionDto
    {
        public PaymentMethods PaymentMethod { get; set; }
        // debito -> + (positivo) ; credito -> - (negativo)
        public double Amount { get; set; }
        public string DocumentType { get; set; }
        public int DocumentNumber { get; set; }
        public int InvoiceId { get; set; }
        public int ClientId { get; set; }
        public static BillingTransaction Convert(BillingTransactionDto dto)
        {
            return DtoMapper.CreateEntityFromDto<BillingTransaction>(dto);
        }
    }
}

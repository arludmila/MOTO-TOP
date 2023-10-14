using Contracts.Utils;
using Entities.Core;

namespace Contracts.DTOs.Entities
{
    public class InvoiceDto
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public int ClientId { get; set; }
        public int? OrderId { get; set; }
        public int? OfficeWorkerId { get; set; }
    }
}

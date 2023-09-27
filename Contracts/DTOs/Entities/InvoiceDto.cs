using Contracts.Utils;
using Entities.Core;

namespace Contracts.DTOs.Entities
{
    public class InvoiceDto
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public int OrderId { get; set; }
        public static Invoice Convert(InvoiceDto dto)
        {
            return DtoMapper.CreateEntityFromDto<Invoice>(dto);
        }
    }
}

using Contracts.Utils;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTOs
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

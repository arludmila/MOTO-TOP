using Contracts.DTOs.Relationships;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTOs.Entities
{
    public class InvoiceWithDetailsDto
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        // TODO: hacer un selector de cliente para el creador de Invoice y de ahi pasar el Id
        // otra migracion tambien
        public int ClientId { get; set; }
        public int? OfficeWorkerId { get; set; }
        public List<OrderProductDto> InvoiceDetails { get; set; } = new List<OrderProductDto>();
    }
}

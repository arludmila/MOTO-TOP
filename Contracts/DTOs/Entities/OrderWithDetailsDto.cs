using Contracts.DTOs.Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTOs.Entities
{
    public class OrderWithDetailsDto
    {
        public DateTime Date { get; set; }
        public int TransportCompanyId { get; set; }
        public int ClientId { get; set; }
        public int SellerId { get; set; }
        public List<OrderProductDto> OrderDetails { get; set; } = new List<OrderProductDto>();
    }
}

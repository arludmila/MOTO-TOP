using Contracts.DTOs.Entities;
using Contracts.Utils;
using Entities.Core;
using Entities.Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTOs.Relationships
{
    public class OrderProductDto
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int? InvoiceId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public static OrderProduct Convert(OrderProductDto dto)
        {
            return DtoMapper.CreateEntityFromDto<OrderProduct>(dto);
        }
    }
}

using Contracts.Utils;
using Entities.Relationships;

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

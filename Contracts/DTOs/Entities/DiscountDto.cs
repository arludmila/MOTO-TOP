using Contracts.Utils;
using Entities.Core;

namespace Contracts.DTOs.Entities
{
    public class DiscountDto
    {
        public string Description { get; set; }
        public double Percentage { get; set; }
        public static Discount Convert(DiscountDto dto)
        {
            return DtoMapper.CreateEntityFromDto<Discount>(dto);
        }
    }
}

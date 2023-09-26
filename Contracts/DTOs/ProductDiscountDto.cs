using Contracts.Utils;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTOs
{
    public class ProductDiscountDto
    {
        public string Description { get; set; }
        public double Percentage { get; set; }
        public static ProductDiscount Convert(ProductDiscountDto dto)
        {
            return DtoMapper.CreateEntityFromDto<ProductDiscount>(dto);
        }
    }
}

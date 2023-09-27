﻿using Contracts.Utils;
using Entities.Core;

namespace Contracts.DTOs.Entities
{
    public class ProductDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public static Product Convert(ProductDto dto)
        {
            return DtoMapper.CreateEntityFromDto<Product>(dto);
        }
    }
}

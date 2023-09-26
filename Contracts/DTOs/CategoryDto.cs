using Contracts.Utils;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTOs
{
    public class CategoryDto
    {
        public string Name { get; set; }
        public static Category Convert(CategoryDto dto)
        {
            return DtoMapper.CreateEntityFromDto<Category>(dto);
        }

    }
}

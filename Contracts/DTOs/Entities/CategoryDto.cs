using Contracts.Utils;
using Entities.Core;

namespace Contracts.DTOs.Entities
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

using Contracts.Utils;
using Entities.Core;

namespace Contracts.DTOs.Entities
{
    public class SupplierDto
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public static Supplier Convert(SupplierDto dto)
        {
            return DtoMapper.CreateEntityFromDto<Supplier>(dto);
        }
    }
}

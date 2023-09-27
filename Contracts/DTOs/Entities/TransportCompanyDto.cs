using Contracts.Utils;
using Entities.Core;

namespace Contracts.DTOs.Entities
{
    public class TransportCompanyDto
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public static TransportCompany Convert(TransportCompanyDto dto)
        {
            return DtoMapper.CreateEntityFromDto<TransportCompany>(dto);
        }
    }
}

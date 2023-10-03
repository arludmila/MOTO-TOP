using Contracts.Utils;
using Entities.Core;

namespace Contracts.DTOs.Entities
{
    public class ClientDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public static Client Convert(ClientDto dto)
        {
            return DtoMapper.CreateEntityFromDto<Client>(dto);
        }
    }
}

using Contracts.Utils;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTOs.Entities
{
    public class ClientDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public static Client Convert(ClientDto dto)
        {
            return DtoMapper.CreateEntityFromDto<Client>(dto);
        }
    }
}

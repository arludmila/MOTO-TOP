using Contracts.Utils;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTOs
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

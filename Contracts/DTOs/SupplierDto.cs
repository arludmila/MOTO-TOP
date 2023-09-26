using Contracts.Utils;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTOs
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

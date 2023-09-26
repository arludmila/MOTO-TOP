using Contracts.Utils;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTOs.Entities
{
    public class SellerDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Zone { get; set; }
        public static Seller Convert(SellerDto dto)
        {
            return DtoMapper.CreateEntityFromDto<Seller>(dto);
        }
    }
}

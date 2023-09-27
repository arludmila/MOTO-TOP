using Business;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : BaseController<Supplier, SupplierDto>
    {
        public SuppliersController(GenericService<Supplier> service)
            : base(service)
        {
        }
    }
}

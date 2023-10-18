using Business.Services;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/suppliers")]
    [ApiController]
    public class SuppliersController : BaseController<Supplier, SupplierDto, int>
    {
        public SuppliersController(GenericService<Supplier, int> service)
            : base(service)
        {
        }
    }
}

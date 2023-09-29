using Business.Services;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportCompaniesController : BaseController<TransportCompany, TransportCompanyDto>
    {
        public TransportCompaniesController(GenericService<TransportCompany> service)
            : base(service)
        {
        }
    }
}

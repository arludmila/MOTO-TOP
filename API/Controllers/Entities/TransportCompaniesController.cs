using Business.Services;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/transport-companies")]
    [ApiController]
    public class TransportCompaniesController : BaseController<TransportCompany, TransportCompanyDto, int>
    {
        public TransportCompaniesController(GenericService<TransportCompany, int> service)
            : base(service)
        {
        }
    }
}

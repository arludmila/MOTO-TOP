using Business.Services;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/clients")]
    [ApiController]
    public class ClientsController : BaseController<Client, ClientDto, int>
    {
        public ClientsController(GenericService<Client, int> service) : base(service)
        {
        }
    }
}

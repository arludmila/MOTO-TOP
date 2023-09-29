using Business.Services;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : BaseController<Client, ClientDto>
    {
        public ClientsController(GenericService<Client> service) : base(service)
        {
        }
    }
}

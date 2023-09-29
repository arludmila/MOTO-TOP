using Business.Services;
using Contracts.DTOs.Relationships;
using Entities.Relationships;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Relationships
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerClientsController : BaseController<SellerClient, SellerClientDto>
    {
        public SellerClientsController(GenericService<SellerClient> service)
            : base(service)
        {
        }
    }
}

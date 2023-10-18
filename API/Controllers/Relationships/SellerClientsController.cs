using Business.Services;
using Contracts.DTOs.Relationships;
using Entities.Relationships;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Relationships
{
    [Route("api/seller-clients")]
    [ApiController]
    public class SellerClientsController : BaseController<SellerClient, SellerClientDto, int>
    {
        public SellerClientsController(GenericService<SellerClient, int> service)
            : base(service)
        {
        }
    }
}

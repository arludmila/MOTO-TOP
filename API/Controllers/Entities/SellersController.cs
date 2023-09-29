using Business.Services;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : BaseController<Seller, SellerDto>
    {
        public SellersController(GenericService<Seller> service) : base(service)
        {
        }
    }
}

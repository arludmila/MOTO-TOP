using Business.Services;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : BaseController<Discount, DiscountDto>
    {
        public DiscountsController(GenericService<Discount> service) : base(service)
        {
        }
    }
}

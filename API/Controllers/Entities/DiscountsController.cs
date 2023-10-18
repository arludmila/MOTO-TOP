using Business.Services;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/discounts")]
    [ApiController]
    public class DiscountsController : BaseController<Discount, DiscountDto, int>
    {
        public DiscountsController(GenericService<Discount, int> service) : base(service)
        {
        }
    }
}

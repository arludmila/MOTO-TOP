using Business.Services;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingTransactionsController : BaseController<BillingTransaction, BillingTransactionDto>
    {
        public BillingTransactionsController(GenericService<BillingTransaction> service) : base(service)
        {
        }
    }
}

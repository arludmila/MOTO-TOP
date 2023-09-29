using Business.Services;
using Business.Services.Entities;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingTransactionsController : BaseController<BillingTransaction, BillingTransactionDto>
    {
        private readonly BillingTransactionService _btService;
        public BillingTransactionsController(BillingTransactionService service) : base(service)
        {
            _btService = service;
        }
        [HttpGet("getClientBalance/{clientId}")]
        public async Task<double> GetOrderTotal(int clientId)
        {
            return await _btService.GetClientBalanceAsync(clientId);
        }
    }
}

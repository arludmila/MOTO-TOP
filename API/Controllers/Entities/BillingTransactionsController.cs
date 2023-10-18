using Business.Services;
using Business.Services.Entities;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/billing-transactions")]
    [ApiController]
    public class BillingTransactionsController : BaseController<BillingTransaction, BillingTransactionDto, int>
    {
        private readonly BillingTransactionService _btService;
        public BillingTransactionsController(BillingTransactionService service) : base(service)
        {
            _btService = service;
        }
        [HttpGet("getClientBalance/{clientId}")]
        public async Task<double> GetClientBalance(int clientId)
        {
            return await _btService.GetClientBalanceAsync(clientId);
        }
    }
}

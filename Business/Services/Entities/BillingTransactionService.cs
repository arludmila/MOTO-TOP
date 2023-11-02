using Contracts.DTOs.Entities;
using Data.Repositories.Entities;
using Entities.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Entities
{
    public class BillingTransactionService : GenericService<BillingTransaction, BillingTransactionDto, int>
    {
        private readonly BillingTransactionRepository _btRepository;

        public BillingTransactionService(BillingTransactionRepository repository) : base(repository)
        {
            _btRepository = repository;
        }
        public async Task<double> GetClientBalanceAsync(int id)
        {
            return await _btRepository.GetClientBalanceAsync(id);
        }
    }
}

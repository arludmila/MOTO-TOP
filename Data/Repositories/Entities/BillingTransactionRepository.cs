using Entities.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Entities
{
    public class BillingTransactionRepository : GenericRepository<BillingTransaction, int>
    {
        public BillingTransactionRepository(MotoTopContext context) : base(context)
        {

        }
        public async Task<double> GetClientBalanceAsync(int id)
        {
            double total = 0;
            var billingTransactions = await _context.Set<BillingTransaction>()
                .Where(x=>x.ClientId==id).ToListAsync();
            foreach (var item in billingTransactions)
            {
                total += item.Amount;
            }
            return total;
        }

    }
}

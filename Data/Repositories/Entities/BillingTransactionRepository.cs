using Contracts.ViewModels;
using Entities.Core;
using Entities.Enums;
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
        public async Task<List<BillingTransactionViewModel>> GetAll()
        {
            var bts = await _context.Set<BillingTransaction>()
                .Include(bt => bt.Client).ToListAsync();
            var result = new List<BillingTransactionViewModel>();
            foreach (var item in bts)
            {
                result.Add(new BillingTransactionViewModel
                {
                    Id = item.Id,
                    PaymentMethod = item.PaymentMethod,
                    Amount = item.Amount,
                    DocumentType = item.DocumentType,
                    DocumentNumber = item.DocumentNumber,
                    InvoiceId = item.InvoiceId,
                    ClientId = item.ClientId,
                    ClientName = $"{item.Client.LastName}, {item.Client.FirstName}",
                });
            }
            return result;
        }

    }
}

using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.SymbolStore;

namespace Data.Repositories.Entities
{
    public class InvoiceRepository : GenericRepository<Invoice>
    {
        public InvoiceRepository(MotoTopContext context) : base(context)
        {

        }
        public override async Task<Invoice> CreateAsync(Invoice invoice)
        {
            var order = await _context.Set<Order>().FirstOrDefaultAsync(x=> x.Id == invoice.OrderId);

            
            _context.Set<Invoice>().Add(invoice);
            await _context.SaveChangesAsync();

            var generatedInvoiceId = invoice.Id;
            var billingTransaction = new BillingTransaction()
            {
                Amount = invoice.Amount,
                InvoiceId = invoice.Id,
                ClientId = order.ClientId,
                DocumentNumber = invoice.Id,
                DocumentType = "Invoice"
            };
            _context.Set<BillingTransaction>().Add(billingTransaction);
            await _context.SaveChangesAsync();
            return invoice;
        }
        public async Task<bool> OrderHasInvoiceAsync(int orderId)
        {
            return await _context.Set<Invoice>().AnyAsync(x => x.OrderId == orderId);
        }
    }
}

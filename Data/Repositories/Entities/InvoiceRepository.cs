using Contracts.DTOs.Entities;
using Entities.Core;
using Entities.Enums;
using Entities.Relationships;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.SymbolStore;

namespace Data.Repositories.Entities
{
    public class InvoiceRepository : GenericRepository<Invoice>
    {
        public InvoiceRepository(MotoTopContext context) : base(context)
        {

        }
        public override async Task<Invoice> CreateInvoiceAsync(Invoice invoice)
        {
            var order = await _context.Set<Order>().FirstAsync(x => x.Id == invoice.OrderId);
            order.HasInvoice = true;
            order.ShipmentStatus = ShipmentStatuses.Preparing;
            _context.Set<Invoice>().Add(invoice);
            await _context.SaveChangesAsync();

            await CreateBTAsync(invoice);
            await SetOrderProductsIdsAsync(invoice);
            return invoice;
        }
        public async Task<bool> OrderHasInvoiceAsync(int orderId)
        {
            return await _context.Set<Invoice>().AnyAsync(x => x.OrderId == orderId);
        }
        private async Task CreateBTAsync(Invoice invoice)
        {
            var order = await _context.Set<Order>().FirstOrDefaultAsync(x => x.Id == invoice.OrderId);

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
        }
        private async Task SetOrderProductsIdsAsync(Invoice invoice)
        {
            var orderProducts = await _context.Set<OrderProduct>()
                .Include(x => x.Product)
                .Where(x => x.OrderId == invoice.OrderId).ToListAsync();
            foreach (var item in orderProducts)
            {
                item.InvoiceId = invoice.Id;
                item.Product.Quantity -= item.Quantity;
            }
            await _context.SaveChangesAsync();
            
        }
    }
}

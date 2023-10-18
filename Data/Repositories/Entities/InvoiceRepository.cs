using Contracts.DTOs.Entities;
using Contracts.ViewModels;
using Entities.Core;
using Entities.Enums;
using Entities.Relationships;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Entities
{
    public class InvoiceRepository : GenericRepository<Invoice, int>
    {
        public InvoiceRepository(MotoTopContext context) : base(context)
        {

        }
        public async Task<List<InvoiceViewModel>> GetAllVMAsync()
        {
            var invoices = await _context.Set<Invoice>()
                .Include(x => x.Order)
                .ToListAsync();
            var billingTransactions = await _context.Set<BillingTransaction>()
                .ToListAsync();
            var result = new List<InvoiceViewModel>();
            foreach (var invoice in invoices)
            {
                double payedAmount = 0;
                foreach (var bt in billingTransactions)
                {
                    if (bt.InvoiceId == invoice.Id)
                    {
                        payedAmount += bt.Amount;
                    }
                }
                var invoiceVM = new InvoiceViewModel
                {
                    Id = invoice.Id,
                    OrderId = invoice.OrderId,
                    Date = invoice.Date,
                    TotalAmount = invoice.Amount,
                    DebtAmount = payedAmount,
                    ClientId = invoice.ClientId,
                };
                result.Add(invoiceVM);
            }
            return result;
        }
        public override async Task<Invoice> CreateInvoiceAsync(Invoice invoice)
        {
            var order = await _context.Set<Order>().FirstAsync(x => x.Id.Equals(invoice.OrderId));
            order.HasInvoice = true;
            order.ShipmentStatus = ShipmentStatuses.Preparing;
            _context.Set<Invoice>().Add(invoice);
            await _context.SaveChangesAsync();

            await CreateBTAsync(invoice);
            await SetOrderProductsIdsAsync(invoice);
            return invoice;
        }
        public async Task<Invoice> CreateInvoiceCentralAsync(InvoiceWithDetailsDto dto)
        {
            var invoice = new Invoice()
            {
                Date = dto.Date,
                Amount = dto.Amount,
                ClientId = dto.ClientId,
            };
            _context.Set<Invoice>().Add(invoice);
            await _context.SaveChangesAsync();

            foreach (var item in dto.InvoiceDetails)
            {
                var orderProduct = new OrderProduct()
                {
                    ProductId = item.ProductId,
                    InvoiceId = invoice.Id,
                    Quantity = item.Quantity,
                    Price = item.Price,
                };
                _context.Set<OrderProduct>().Add(orderProduct);
                await _context.SaveChangesAsync();
            }

            await _context.SaveChangesAsync();
            await SetOrderProductsIdsAsync(invoice);
            await CreateBTAsync(invoice);
            return invoice;
        }
        public async Task<bool> OrderHasInvoiceAsync(int orderId)
        {
            return await _context.Set<Invoice>().AnyAsync(x => x.OrderId.Equals(orderId));
        }
        private async Task CreateBTAsync(Invoice invoice)
        {
            var order = await _context.Set<Order>().FirstOrDefaultAsync(x => x.Id.Equals(invoice.OrderId));

            var billingTransaction = new BillingTransaction()
            {
                Amount = invoice.Amount,
                InvoiceId = invoice.Id,
                ClientId = invoice.ClientId,
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
                .Where(x => x.OrderId.Equals(invoice.OrderId)).ToListAsync();
            foreach (var item in orderProducts)
            {
                item.InvoiceId = invoice.Id;
                item.Product.Quantity -= item.Quantity;
            }
            await _context.SaveChangesAsync();

        }
    }
}

using Entities.Core;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Entities
{
    public class InvoiceRepository : GenericRepository<Invoice>
    {
        public InvoiceRepository(MotoTopContext context) : base(context)
        {

        }

        public async Task<bool> OrderHasInvoiceAsync(int orderId)
        {
            return await _context.Set<Invoice>().AnyAsync(x => x.OrderId == orderId);
        }
    }
}

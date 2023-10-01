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
    public class OrderRepository : GenericRepository<Order>
    {
        public OrderRepository(MotoTopContext context) : base(context)
        {

        }
        public async Task<double> GetOrderTotalAsync(int id)
        {
            double total = 0;
            var orderProducts = await _context.OrderProducts
                .Where(x => x.OrderId == id)
                .ToListAsync(); 

            foreach (var item in orderProducts)
            {
                total += item.Price * item.Quantity;
            }

            return total;
        }
        public async Task<ShipmentStatuses> GetOrderStatusAsync(int id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);
            return order.ShipmentStatus;
        }
    }
}

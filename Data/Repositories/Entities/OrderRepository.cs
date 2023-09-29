using Entities.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Entities
{
    public class OrderRepository
    {
        private readonly MotoTopContext _context;
        public OrderRepository(MotoTopContext context)
        {
            _context = context;
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
    }
}

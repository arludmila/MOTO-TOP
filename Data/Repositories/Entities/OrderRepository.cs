using Contracts.ViewModels;
using Entities.Core;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Entities
{
    public class OrderRepository : GenericRepository<Order>
    {
        public OrderRepository(MotoTopContext context) : base(context)
        {

        }
        public async Task<List<OrderViewModel>> GetAllAsync()
        {

            var orders = await _context.Set<Order>()
                .Include(x => x.TransportCompany)
                .Include(x => x.Seller)
                    .ThenInclude(seller => seller.User)
                .Include(x => x.Client)
                .ToListAsync();
            List<OrderViewModel> result = new List<OrderViewModel>();
            foreach (var order in orders)
            {
                string shipmentStatus = string.Empty;
                switch (order.ShipmentStatus)
                {
                    case ShipmentStatuses.Received:
                        shipmentStatus = "Recibido";
                        break;
                    case ShipmentStatuses.Preparing:
                        shipmentStatus = "En Preparación";
                        break;
                    case ShipmentStatuses.Shipped:
                        shipmentStatus = "Enviado";
                        break;
                    default:
                        break;
                }
                var orderVM = new OrderViewModel
                {
                    Id = order.Id,
                    ShipmentStatus = shipmentStatus,
                    ClientName = $"{order.Client.LastName}, {order.Client.FirstName}",
                    SellerName = $"{order.Seller.User.LastName}, {order.Seller.User.FirstName}",
                    TransportCompanyName = $"{order.TransportCompany.Name}",
                    DateSent = order.DateSent,
                    DateReceived = order.DateReceived,
                    HasInvoice = order.HasInvoice,
                };
                result.Add(orderVM);
            }
            return result;
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

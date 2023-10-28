using Contracts.DTOs.Entities;
using Contracts.ViewModels;
using Entities.Core;
using Entities.Enums;
using Entities.Relationships;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Entities
{
    public class OrderRepository : GenericRepository<Order, Guid>
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
                var orderDetails = await _context.Set<OrderProduct>()
                    .Include(x => x.Product)
                        .ThenInclude(product => product.Category)
                    .Where(x => x.OrderId.Equals(order.Id))
                    .ToListAsync();

                List<OrderProductViewModel> orderProductResult = new List<OrderProductViewModel>();

                foreach (var item in orderDetails)
                {
                    var orderProductVM = new OrderProductViewModel()
                    {
                        Id = item.Id,
                        
                        ProductId = item.ProductId,
                        OrderId = item.OrderId,
                        InvoiceId = item.InvoiceId,
                        Quantity = item.Quantity,
                        Price = item.Price,
                        ProductCategoryName = item.Product.Category.Name,
                        ProductName = item.Product.Name,
                        ProductQuantity = item.Product.Quantity,
                    };
                    orderProductResult.Add(orderProductVM);
                }

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
                    Date = order.Date,
                    ShipmentStatus = shipmentStatus,
                    ClientName = $"{order.Client.LastName}, {order.Client.FirstName}",
                    SellerName = $"{order.Seller.User.LastName}, {order.Seller.User.FirstName}",
                    TransportCompanyName = $"{order.TransportCompany.Name}",
                    DateSent = order.DateSent,
                    DateReceived = order.DateReceived,
                    HasInvoice = order.HasInvoice,
                    OrderProducts = orderProductResult,
                };

                result.Add(orderVM);
            }

            return result;
        }

        public async Task<OrderViewModel> GetByIdAsync(Guid id)
        {
            var order = await _context.Set<Order>()
                .Include(x => x.TransportCompany)
                .Include(x => x.Seller)
                    .ThenInclude(seller => seller.User)
                .Include(x => x.Client)
                .FirstOrDefaultAsync(x => x.Id.Equals(id));
            var orderDetails = await _context.Set<OrderProduct>()
                .Include(x => x.Product)
                    .ThenInclude(product => product.Category)
                .Where(x => x.OrderId == id)
                .ToListAsync();
            List<OrderProductViewModel> result = new List<OrderProductViewModel>();
            foreach (var item in orderDetails)
            {
                var orderProductVM = new OrderProductViewModel()
                {
                    Id = item.Id,
                    ProductId = item.ProductId,
                    OrderId = item.OrderId,
                    InvoiceId = item.InvoiceId,
                    Quantity = item.Quantity,
                    Price = item.Price,
                    ProductCategoryName = item.Product.Category.Name,
                    ProductName = item.Product.Name,
                    ProductQuantity = item.Product.Quantity,
                };
                result.Add(orderProductVM);
            }

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
                Date = order.Date,
                ShipmentStatus = shipmentStatus,
                ClientName = $"{order.Client.LastName}, {order.Client.FirstName}",
                SellerName = $"{order.Seller.User.LastName}, {order.Seller.User.FirstName}",
                TransportCompanyName = $"{order.TransportCompany.Name}",
                DateSent = order.DateSent,
                DateReceived = order.DateReceived,
                HasInvoice = order.HasInvoice,
                OrderProducts = result,
            };
            return orderVM;
        }
        public async Task<double> GetOrderTotalAsync(Guid id)
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
        public async Task<ShipmentStatuses> GetOrderStatusAsync(Guid id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id.Equals(id));
            return order.ShipmentStatus;
        }
        //
        public async Task<Order> CreateDetailedOrderAsync(OrderWithDetailsDto dto)
        {
            var order = new Order()
            {
                Date = dto.Date,
                ClientId = dto.ClientId,
                TransportCompanyId = dto.TransportCompanyId,
                SellerId = dto.SellerId,
                ShipmentStatus = ShipmentStatuses.Received,
                HasInvoice = false,
            };
            _context.Set<Order>().Add(order);
            await _context.SaveChangesAsync();

            foreach (var item in dto.OrderDetails)
            {
                var orderProduct = new OrderProduct()
                {
                    ProductId = item.ProductId,
                    OrderId = order.Id,
                    Quantity = item.Quantity,
                    Price = item.Price,
                };
                _context.Set<OrderProduct>().Add(orderProduct);
                await _context.SaveChangesAsync();
            }

            await _context.SaveChangesAsync();
            return order;
        }
        
       
    }
}

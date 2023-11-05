using Contracts.DTOs.Reports;
using Contracts.ViewModels;
using Contracts.ViewModels.Reports;
using Entities.Core;
using Entities.Enums;
using Entities.Relationships;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ReportRepository
    {
        protected readonly MotoTopContext _context;

        public ReportRepository(MotoTopContext context)
        {
            _context = context;
        }
        public List<SellersSalesViewModel> GetSellersSales(DateFromToDto dto)
        {
            var result = _context.Invoices
                .Include(i => i.Order)
                    .ThenInclude(o => o.Seller)
                     .ThenInclude(s => s.User)
                .Where(i => i.Order != null)
                .GroupBy(i => i.Order.SellerId)
                .Select(grouped => new SellersSalesViewModel
                {
                    SellerId = grouped.Key,
                    FirstName = grouped.First().Order.Seller.User.FirstName,
                    LastName = grouped.First().Order.Seller.User.LastName,
                    Zone = grouped.First().Order.Seller.Zone,
                    TotalSales = grouped.Count(),
                    TotalAmount = grouped.Sum(i => i.Amount)
                })
                .ToList();

            return result;
        }









        public async Task<List<OrderViewModel>> GetOrdersPendingShipment()
        {
            var orders = await _context.Set<Order>()
                .Include(order => order.Client)
                .Include(order => order.Seller)
                    .ThenInclude(seller => seller.User)
                .Include(order => order.TransportCompany)
                .Where(order => order.ShipmentStatus != ShipmentStatuses.Shipped && order.HasInvoice)
                .ToListAsync();
            var result = new List<OrderViewModel>();

            foreach (var order in orders)
            {
                // TODO: revisar -> deje como nulo datesent, datereceived y hasinvoice!!!
                var orderVM= new OrderViewModel()
                {
                    Id = order.Id,
                    Date = order.Date,
                    ShipmentStatus = order.ShipmentStatus.ToString(),
                    ClientName = $"{order.Client.LastName}, {order.Client.FirstName}",
                    SellerName = $"{order.Seller.User.LastName}, {order.Seller.User.FirstName}",
                    
                };
                if (orderVM.TransportCompanyName != null)
                {
                    orderVM.TransportCompanyName = order.TransportCompany.Name;
                }
                result.Add(orderVM);

            }

            return result;

        }
        public async Task<List<ClientsBalanceViewModel>> GetClientsBlances()
        {
            var clientBalances = await _context.Set<BillingTransaction>()
                     .Include(bt => bt.Client)
                     .GroupBy(bt => bt.Client)
                     .Select(group => new ClientsBalanceViewModel
                     {
                         Id = group.Key.Id,
                         FirstName = group.Key.FirstName,
                         LastName = group.Key.LastName,
                         Location = group.Key.Location,
                         PhoneNumber = group.Key.PhoneNumber,
                         DocumentNumber = group.Key.DocumentNumber,
                         DocumentType = group.Key.DocumentType,
                         Email = group.Key.Email,
                         TotalBalance = group.Sum(bt => bt.Amount)
                     })
                     .ToListAsync();
            return clientBalances;
           


        }
        // Informe de Total de ventas en un periodo;
        public async Task<List<Invoice>> GetTotalSales(DateFromToDto dto)
        {
            var invoices = await _context.Set<Invoice>()
                .Where(i => i.Date >= dto.From && i.Date <= dto.To)
                .ToListAsync();
                     
            return invoices;

        }
        // informe total de compras x clientes;
        public async Task<List<ClientPurchasesViewModel>> GetClientsPurchases(DateFromToDto dto)
        {
            var result = _context.Set<Invoice>()
                .Include(i => i.Client)
                .GroupBy(i => i.ClientId)
                .Select(grouped => new ClientPurchasesViewModel
                {
                    ClientId = grouped.Key,
                    FirstName = grouped.First().Client.FirstName,
                    LastName = grouped.First().Client.LastName,
                    DocumentType = grouped.First().Client.DocumentType.ToString(),
                    DocumentNumber = grouped.First().Client.DocumentNumber,
                    Email = grouped.First().Client.Email,
                    PhoneNumber = grouped.First().Client.PhoneNumber,
                    TotalAmount = grouped.Sum(i => i.Amount),
                    TotalPurchases = grouped.Count(),
                }).ToList();
            return result;
        }
        // TODO: ventas de productos x periodo;
        public async Task<List<ProductSalesViewModel>> GetProductsSales(DateFromToDto dto)
        {
            var result = _context.Set<OrderProduct>()
                .Include(op => op.Product)
                    .ThenInclude(p => p.Category)

                .GroupBy(p => p.ProductId)
                .Select(grouped => new ProductSalesViewModel
                {
                    Id = grouped.Key,
                    Name = grouped.First().Product.Name,
                    CategoryName = grouped.First().Product.Category.Name,
                    Description = grouped.First().Product.Description,
                    TotalAmount = grouped.Sum(p => p.Price),
                    TotalSales = grouped.Sum(p => p.Quantity),
                }).ToList();
            return result;
        }
    }
}

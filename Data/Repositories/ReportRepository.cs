using Contracts.DTOs.Reports;
using Contracts.ViewModels;
using Contracts.ViewModels.Reports;
using Entities.Core;
using Entities.Enums;
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
        public List<SellersSalesViewModel> GetSellersSales(SellersSalesDto dto)
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
            // TODO: Informe de Total de ventas en un periodo ;  Facturar pendientes de cobro

        }
    }
}

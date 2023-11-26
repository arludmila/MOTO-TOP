using Contracts.DTOs.Reports;
using Contracts.ViewModels;
using Contracts.ViewModels.Reports;
using Data.Repositories;
using Entities.Core;
using Entities.Relationships;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ReportService
    {
        private readonly ReportRepository _repository;

        public ReportService(ReportRepository repository)
        {
            _repository = repository;
        }
        public List<SellersSalesViewModel> GetSellersSales(DateFromToDto dto)
        {
            return _repository.GetSellersSales(dto);
        }
        public async Task<List<OrderViewModel>> GetOrdersPendingShipment()
        {
            return await _repository.GetOrdersPendingShipment();
        }
        public async Task<List<ClientsBalanceViewModel>> GetClientsBlances()
        {
            return await _repository.GetClientsBlances();
        }
        // Informe de Total de ventas en un periodo;
        public async Task<List<InvoiceViewModel>> GetTotalSales(DateFromToDto dto)
        {
            return await _repository.GetTotalSales(dto);
        }
        // informe total de compras x clientes;
        public async Task<List<ClientPurchasesViewModel>> GetClientsPurchases(DateFromToDto dto)
        {
            return await _repository.GetClientsPurchases(dto);
        }
        //
        public async Task<List<ProductSalesViewModel>> GetProductsSales(DateFromToDto dto)
        {
            return await _repository.GetProductsSales(dto);
        }
    }
}

using Contracts.DTOs.Reports;
using Contracts.ViewModels;
using Contracts.ViewModels.Reports;
using Data.Repositories;
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
        public List<SellersSalesViewModel> GetSellersSales(SellersSalesDto dto)
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
    }
}

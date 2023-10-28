﻿using Business.Services;
using Contracts.DTOs.Reports;
using Contracts.ViewModels;
using Contracts.ViewModels.Reports;
using Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/reports")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly ReportService _service;

        public ReportsController(ReportService service)
        {
            _service = service;
        }
        [HttpPost("sellers-sales")]
        public List<SellersSalesViewModel> GetSellersSales(SellersSalesDto dto)
        {
            return _service.GetSellersSales(dto);
        }
        [HttpGet("orders-pending-shipment")]
        public async Task<List<OrderViewModel>> GetOrdersPendingShipment()
        {
            return await _service.GetOrdersPendingShipment();
        }
        [HttpGet("clients-balances")]
        public async Task<List<ClientsBalanceViewModel>> GetClientsBlances()
        {
            return await _service.GetClientsBlances();
        }
    }
}

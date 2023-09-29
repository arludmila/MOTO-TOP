using Data;
using Data.Repositories;
using Data.Repositories.Entities;
using Entities.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Entities
{
    public class InvoiceService : GenericService<Invoice>
    {
        private readonly InvoiceRepository _invoiceRepository;

        public InvoiceService(InvoiceRepository repository) : base(repository)
        {
            _invoiceRepository = repository;
        }
        public override async Task<Invoice> CreateAsync(Invoice invoice)
        {
            return await _invoiceRepository.CreateAsync(invoice);
        }
        public async Task<bool> OrderHasInvoiceAsync(int orderId)
        {
            return await _invoiceRepository.OrderHasInvoiceAsync(orderId);
        }
    }
}

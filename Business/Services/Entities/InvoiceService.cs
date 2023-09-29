using Data;
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
        private readonly InvoiceRepository _repository;

        public InvoiceService(InvoiceRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<bool> OrderHasInvoiceAsync(int orderId)
        {
            return await _repository.OrderHasInvoiceAsync(orderId);
        }
    }
}

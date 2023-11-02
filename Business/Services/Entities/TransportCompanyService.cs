using Contracts.DTOs.Entities;
using Data.Repositories;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Entities
{
    public class TransportCompanyService : GenericService<TransportCompany, TransportCompanyDto, int>
    {
        private readonly GenericRepository<TransportCompany, int> _repository;

        public TransportCompanyService(GenericRepository<TransportCompany, int> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}

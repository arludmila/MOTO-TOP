using Contracts.DTOs.Relationships;
using Data.Repositories;
using Entities.Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Relationships
{
    public class SellerClientService : GenericService<SellerClient, SellerClientDto, int>
    {
        private readonly GenericRepository<SellerClient, int> _repository;

        public SellerClientService(GenericRepository<SellerClient, int> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}

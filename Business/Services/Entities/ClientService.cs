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
    public class ClientService : GenericService<Client, ClientDto, int>
    {
        private readonly GenericRepository<Client, int> _repository;

        public ClientService(GenericRepository<Client, int> repository) : base(repository)
        {
            _repository = repository;
        }
    
    }
}

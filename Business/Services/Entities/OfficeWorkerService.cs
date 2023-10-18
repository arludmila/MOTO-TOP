using Contracts.ViewModels;
using Data.Repositories.Entities;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Entities
{
    public class OfficeWorkerService : GenericService<OfficeWorker, int>
    {
        private readonly OfficeWorkerRepository _offWorkerRepository;

        public OfficeWorkerService(OfficeWorkerRepository repository) : base(repository)
        {
            _offWorkerRepository = repository;
        }
        public async Task<List<OfficeWorkerViewModel>> GetAllAsync()
        {
            return await _offWorkerRepository.GetAllAsync();
        }
    }
}

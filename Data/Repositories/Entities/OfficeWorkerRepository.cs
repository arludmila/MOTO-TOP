using Contracts.ViewModels;
using Entities.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Entities
{
    public class OfficeWorkerRepository : GenericRepository<OfficeWorker, int>
    {
        public OfficeWorkerRepository(MotoTopContext context) : base(context)
        {

        }
        public async Task<List<OfficeWorkerViewModel>> GetAllAsync()
        {

            var officeWorkers = await _context.Set<OfficeWorker>()
                .Include(x => x.User)
                .ToListAsync();
            List<OfficeWorkerViewModel> result = new List<OfficeWorkerViewModel>();
            foreach (var ow in officeWorkers)
            {
                var officeWorkerVM = new OfficeWorkerViewModel
                {
                    Id = ow.Id,
                    FirstName = ow.User.FirstName,
                    LastName = ow.User.LastName,
                    Email = ow.User.Email,
                    DocumentType = ow.User.DocumentType,
                    DocumentNumber = ow.User.DocumentNumber,
                };
                result.Add(officeWorkerVM);
            }
            return result;
        }
    }
}

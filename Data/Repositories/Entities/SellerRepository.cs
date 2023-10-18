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
    public class SellerRepository : GenericRepository<Seller, int>
    {
        public SellerRepository(MotoTopContext context) : base(context)
        {

        }
        public async Task<List<SellerViewModel>> GetAllAsync()
        {

            var sellers = await _context.Set<Seller>().Include(x => x.User).ToListAsync();
            List<SellerViewModel> result = new List<SellerViewModel>();
            foreach (var seller in sellers)
            {
                var sellerVM = new SellerViewModel
                {
                    Id = seller.Id,
                    FirstName = seller.User.FirstName,
                    LastName = seller.User.LastName,
                    Zone = seller.Zone,
                    Email = seller.User.Email,
                    DocumentType = seller.User.DocumentType,
                    DocumentNumber = seller.User.DocumentNumber,
                };
                result.Add(sellerVM);
            }
            return result;
        }
    }
}

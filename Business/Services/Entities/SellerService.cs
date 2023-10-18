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
    public class SellerService : GenericService<Seller, int>
    {
        private readonly SellerRepository _sellerRepository;

        public SellerService(SellerRepository repository) : base(repository)
        {
            _sellerRepository = repository;
        }
        public async Task<List<SellerViewModel>> GetAllAsync()
        {
            return await _sellerRepository.GetAllAsync();
        }
    }
}

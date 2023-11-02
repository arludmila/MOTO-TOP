using Contracts.DTOs.Entities;
using Contracts.ViewModels;
using Data;
using Data.Repositories.Entities;
using Entities.Core;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Entities
{
    public class SellerService : GenericService<Seller, SellerDto, int>
    {
        private readonly SellerRepository _sellerRepository;

        public SellerService(SellerRepository repository) : base(repository)
        {
            _sellerRepository = repository;
        }
        public async Task<Seller> Register(SellerRegisterDto registerDto)
        {
            var userDto = new UserDto()
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Email = registerDto.Email,
                PasswordHash = registerDto.PasswordHash,
                DocumentNumber = registerDto.DocumentNumber,
                DocumentType = registerDto.DocumentType,
                Role = Roles.OfficeWorker,
            };
            // TODO: mirar!!!
            var context = new MotoTopContext();
            var userRepository = new UserRepository(context);
            var userService = new UserService(userRepository);
            //
            int userId = await userService.Create(userDto);
            var sellerDto = new SellerDto()
            {
                Zone = registerDto.Zone,
                UserId = userId,
            };
            return await base.CreateAsync(sellerDto);
        }
        public async Task<List<SellerViewModel>> GetAllAsync()
        {
            return await _sellerRepository.GetAllAsync();
        }
    }
}

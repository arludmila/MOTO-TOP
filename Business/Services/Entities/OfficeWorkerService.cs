using Contracts.DTOs.Entities;
using Contracts.Utils;
using Contracts.ViewModels;
using Data;
using Data.Repositories.Entities;
using Entities.Core;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Entities
{
    public class OfficeWorkerService : GenericService<OfficeWorker, OfficeWorkerDto, int>
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
        public async Task<OfficeWorker> Register(UserDto registerDto)
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
            var sellerDto = new OfficeWorkerDto()
            {
                UserId = userId,
            };
            return await base.CreateAsync(sellerDto);
        }
    }
}

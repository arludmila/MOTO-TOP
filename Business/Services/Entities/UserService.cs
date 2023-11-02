using Contracts.DTOs.Entities;
using Data.Repositories.Entities;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Entities
{
    public class UserService : GenericService<User, UserDto, int>
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository repository) : base(repository)
        {
            _userRepository = repository;
        }
        public async Task<int> Create(UserDto dto)
        {
            User createdUser = await base.CreateAsync(dto);
            return createdUser.Id;
        }
    }
}

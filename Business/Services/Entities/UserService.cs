using Data.Repositories.Entities;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Entities
{
    public class UserService : GenericService<User, int>
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository repository) : base(repository)
        {
            _userRepository = repository;
        }
    }
}

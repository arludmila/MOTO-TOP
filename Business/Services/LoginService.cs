using Contracts.DTOs;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class LoginService
    {
        private readonly LoginRepository _repository;

        public LoginService(LoginRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> LoginMobile(LoginRequestDto loginRequest)
        {
            return await _repository.LoginMobile(loginRequest);
        }
    }
}

using Business.Services;
using Contracts.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _service;

        public LoginController(LoginService service)
        {
            _service = service;
        }
        [HttpPost("seller")]
        public async Task<int> LoginMobile(LoginRequestDto loginRequest)
        {
            return await _service.LoginMobile(loginRequest);
        }
    }
}

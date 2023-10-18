using Business.Services.Entities;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : BaseController<User, UserDto, int>
    {
        private readonly UserService _userService;
        public UsersController(UserService service) : base(service)
        {
            _userService = service;
        }
        
    }
}

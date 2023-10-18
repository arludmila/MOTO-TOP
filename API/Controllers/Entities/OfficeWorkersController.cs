using Business.Services.Entities;
using Contracts.DTOs.Entities;
using Contracts.Utils;
using Contracts.ViewModels;
using Entities.Core;
using Entities.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers.Entities
{
    [Route("api/office-workers")]
    [ApiController]
    public class OfficeWorkersController : BaseController<OfficeWorker, OfficeWorkerDto, int>
    {
        private readonly OfficeWorkerService _offWorkerService;
        public OfficeWorkersController(OfficeWorkerService service) : base(service)
        {
            _offWorkerService = service;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserDto registerDto)
        {
            // ¡¡¡esto deberia venir en el dto de la llamada ya!!!
            //PasswordHasher<string> passwordHasher = new();
            //registerDto.PasswordHash = passwordHasher.HashPassword(string.Empty, registerDto.PasswordHash);
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
            var response = await ApiHelper.PostAsync("https://localhost:7215/api/users", userDto);
            User user = JsonConvert.DeserializeObject<User>(response);
            var sellerDto = new OfficeWorkerDto()
            {
                UserId = user.Id,
            };
            return await base.CreateAsync(sellerDto);
        }
        [HttpGet("view-models")]
        public async Task<List<OfficeWorkerViewModel>> GetAll()
        {
            return await _offWorkerService.GetAllAsync();
        }
    }
}

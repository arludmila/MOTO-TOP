﻿using Business.Services.Entities;
using Contracts.DTOs.Entities;
using Contracts.Utils;
using Contracts.ViewModels;
using Entities.Core;
using Entities.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers.Entities
{
    [Route("api/sellers")]
    [ApiController]
    public class SellersController : BaseController<Seller, SellerDto, int>
    {
        private readonly SellerService _sellerService;
        public SellersController(SellerService service) : base(service)
        {
            _sellerService = service;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] SellerRegisterDto registerDto)
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
                Role = Roles.Seller,
            };
            var response = await ApiHelper.PostAsync("https://localhost:7215/api/users", userDto);
            User user = JsonConvert.DeserializeObject<User>(response);
            var sellerDto = new SellerDto()
            {
                Zone = registerDto.Zone,
                UserId = user.Id,
            };
            return await base.CreateAsync(sellerDto);
        }
        [HttpGet("view-models")]
        public async Task<List<SellerViewModel>> GetAll()
        {
            return await _sellerService.GetAllAsync();
        }
    }
}

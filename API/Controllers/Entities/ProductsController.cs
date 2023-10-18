﻿using Business.Services;
using Business.Services.Entities;
using Contracts.DTOs.Entities;
using Contracts.ViewModels;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : BaseController<Product, ProductDto, int>
    {
        private readonly ProductService _productService;
        public ProductsController(ProductService service) : base(service)
        {
            _productService = service;
        }

        [HttpGet("view-models")]
        public async Task<List<ProductViewModel>> GetAll()
        {
            return await _productService.GetAllAsync();
        }
    }
}

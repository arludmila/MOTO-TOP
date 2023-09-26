﻿using Business;
using Contracts.DTOs;
using Contracts.Utils;
using Entities.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly GenericService<Product> _service;
        public ProductsController(GenericService<Product> service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ProductDto dto)
        {
            try
            {
                var createdEntity = await _service.CreateAsync(ProductDto.Convert(dto));
                return Ok(createdEntity); // Return the created entity as JSON response.
            }
            catch (Exception ex)
            {
                // Handle any exceptions, log them, and return an error response.
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            try
            {
                var entity = await _service.GetByIdAsync(id);
                if (entity == null)
                {
                    return NotFound(); // Return a 404 Not Found response if the entity doesn't exist.
                }
                return Ok(entity); // Return the entity as a JSON response.
            }
            catch (Exception ex)
            {
                // Handle any exceptions, log them, and return an error response.
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var entities = await _service.GetAllAsync();
                return Ok(entities); // Return the entities as a JSON response.
            }
            catch (Exception ex)
            {
                // Handle any exceptions, log them, and return an error response.
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] ProductDto dto)
        {
            try
            {
                var existingEntity = await _service.GetByIdAsync(id);
                if (existingEntity == null)
                {
                    return NotFound(); // Return a 404 Not Found response if the entity doesn't exist.
                }

                DtoMapper.MapDtoToEntity(dto, existingEntity);

                await _service.UpdateAsync(existingEntity);

                return Ok(existingEntity); // Return the updated Category entity as a JSON response.
            }
            catch (Exception ex)
            {
                // Handle any exceptions, log them, and return an error response.
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return NoContent(); // Return a 204 No Content response on successful deletion.
            }
            catch (Exception ex)
            {
                // Handle any exceptions, log them, and return an error response.
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}

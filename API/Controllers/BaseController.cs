using Business.Services;
using Contracts.Utils;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]

    public class BaseController<TEntity, TDto, TId> : ControllerBase where TEntity : class, new()
    {
        protected readonly GenericService<TEntity, TId> _service;

        protected BaseController(GenericService<TEntity, TId> service)
        {
            _service = service;
        }

        [HttpPost]
        public virtual async Task<IActionResult> CreateAsync([FromBody] TDto dto)
        {
            try
            {
                var createdEntity = await _service.CreateAsync(DtoMapper.CreateEntityFromDto<TEntity>(dto));
                return Ok(createdEntity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message} \nInner Exception: {ex.InnerException}");
            }
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetByIdAsync(TId id)
        {
            try
            {
                var entity = await _service.GetByIdAsync(id);
                if (entity == null)
                {
                    return NotFound();
                }
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var entities = await _service.GetAllAsync();
                return Ok(entities);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(TId id, [FromBody] TDto dto)
        {
            try
            {
                var existingEntity = await _service.GetByIdAsync(id);
                if (existingEntity == null)
                {
                    return NotFound();
                }

                DtoMapper.MapDtoToEntity(dto, existingEntity);

                await _service.UpdateAsync(existingEntity);

                return Ok(existingEntity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(TId id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}

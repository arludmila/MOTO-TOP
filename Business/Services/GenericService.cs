using Contracts.Utils;
using Data.Repositories;

namespace Business.Services
{
    public class GenericService<TEntity, TDto, TId> where TEntity : class, new()
    {
        private readonly GenericRepository<TEntity, TId> _repository;

        public GenericService(GenericRepository<TEntity, TId> repository)
        {
            _repository = repository;
        }

        // Create operation (Async)
        public virtual async Task<TEntity> CreateAsync(TDto dto)
        {
            return await _repository.CreateInvoiceAsync(DtoMapper.CreateEntityFromDto<TEntity>(dto));
        }

        // Read operation (Async) - Get an entity by ID
        public async Task<TEntity> GetByIdAsync(TId id)
        {
            return await _repository.GetByIdAsync(id);
        }

        // Read operation (Async) - Get all entities
        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        // Update operation (Async)
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        // Delete operation (Async)
        public async Task DeleteAsync(TId id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}

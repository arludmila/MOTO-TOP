using Data.Repositories;

namespace Business.Services
{
    public class GenericService<T> where T : class
    {
        private readonly GenericRepository<T> _repository;

        public GenericService(GenericRepository<T> repository)
        {
            _repository = repository;
        }

        // Create operation (Async)
        public virtual async Task<T> CreateAsync(T entity)
        {
            return await _repository.CreateInvoiceAsync(entity);
        }

        // Read operation (Async) - Get an entity by ID
        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        // Read operation (Async) - Get all entities
        public async Task<List<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        // Update operation (Async)
        public async Task<T> UpdateAsync(T entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        // Delete operation (Async)
        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}

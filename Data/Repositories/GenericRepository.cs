using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    // T = Entity
    public class GenericRepository<T, TId> where T : class
    {
        protected readonly MotoTopContext _context;

        public GenericRepository(MotoTopContext context)
        {
            _context = context;
        }

        // Create operation (Async)
        public virtual async Task<T> CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        // Read operation (Async) - Get an entity by ID
        public virtual async Task<T> GetByIdAsync(TId id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        // Read operation (Async) - Get all entities
        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        // Update operation (Async)
        public virtual async Task<T> UpdateAsync(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        // Delete operation (Async)
        public virtual async Task DeleteAsync(TId id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}

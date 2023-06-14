using CarWebAPI.Entities.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CarWebAPI.Data.Repositores.BaseRepsitory
{

    public class PaginatedData<T> where T : class
    {
        public IEnumerable<T> Data { get; set; }
        public int TotalPages { get; set; }
    }
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<T>();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<PaginatedData<T>> GetPaginatedAndFilteredData(int pageNumber, int pageSize, Func<T, bool> filter)
        {
            int itemsToSkip = (pageNumber - 1) * pageSize;

            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter).AsQueryable();
            }
            int totalItems = await query.CountAsync();

            IEnumerable<T> data = await query
                .Skip(itemsToSkip)
                .Take(pageSize)
                .ToListAsync();
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            return new PaginatedData<T>
            {
                Data = data,
                TotalPages = totalPages
            };
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.SingleOrDefaultAsync(predicate);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await Task.CompletedTask;
        }

        public async Task RemoveAsync(T entity)
        {
            _dbSet.Remove(entity);
            await Task.CompletedTask;
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
            await Task.CompletedTask;
        }

        public async Task SaveChangesAsync()
        {
           await _context.SaveChangesAsync();
        }
    }

}

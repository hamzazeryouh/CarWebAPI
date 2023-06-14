using CarWebAPI.Entities.Domain;
using System.Linq.Expressions;

namespace CarWebAPI.Data.Repositores.BaseRepsitory
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(object id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<PaginatedData<T>> GetPaginatedAndFilteredData(int pageNumber, int pageSize, Func<T, bool> filter);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);

        Task SaveChangesAsync();
    }
}

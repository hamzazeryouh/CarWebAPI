using CarWebAPI.Modules;

namespace CarWebAPI.Services.BaseService
{
    public interface IBaseService<T> where T : class
    {
        Task<BaseResponse<T>> GetByIdAsync(int id);
        Task<BaseResponse<IEnumerable<T>>> GetAllAsync();
        Task<BaseResponse<T>> CreateAsync(T entity);
        Task<BaseResponse<T>> UpdateAsync(int id, T entity);
        Task<BaseResponse<bool>> DeleteAsync(int id);
        T MapDTOToEntity(T newEntity, T OldEntity);
        Task<BaseResponse<IEnumerable<T>>> GetPaginatedAndFilteredData(int pageNumber, int pageSize, Func<T, bool> filter);
    }
}

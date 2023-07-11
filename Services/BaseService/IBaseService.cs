using CarWebAPI.Modules;

namespace CarWebAPI.Services.BaseService
{
    public interface IBaseService<T, TResponse> where T : class
    {
        Task<BaseResponse<TResponse>> GetByIdAsync(string id);
        Task<BaseResponse<IEnumerable<TResponse>>> GetAllAsync();
        Task<BaseResponse<TResponse>> CreateAsync(T entity);
        Task<BaseResponse<TResponse>> UpdateAsync(string id, T entity);
        Task<BaseResponse<bool>> DeleteAsync(string id);
        Task<BaseResponse<IEnumerable<TResponse>>> GetPaginatedAndFilteredData(int pageNumber, int pageSize, Func<T, bool> filter);
    }
}

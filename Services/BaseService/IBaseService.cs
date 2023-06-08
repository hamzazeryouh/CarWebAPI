using CarWebAPI.Modules;

namespace CarWebAPI.Services.BaseService
{
    public interface IBaseService<T, TResponse> where T : class
    {
        Task<BaseResponse<TResponse>> GetByIdAsync(object id);
        Task<BaseResponse<IEnumerable<TResponse>>> GetAllAsync();
        Task<BaseResponse<TResponse>> CreateAsync(T entity);
        Task<BaseResponse<TResponse>> UpdateAsync(object id, T entity);
        Task<BaseResponse<bool>> DeleteAsync(object id);
    }
}

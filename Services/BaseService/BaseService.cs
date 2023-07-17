using AutoMapper;
using CarWebAPI.Data.Repositores.BaseRepsitory;

namespace CarWebAPI.Services.BaseService
{
    using AutoMapper;
    using Azure;
    using CarWebAPI.Modules;

    public class BaseService<T, TResponse> : IBaseService<T, TResponse> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly IMapper _mapper;

        public BaseService(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<BaseResponse<TResponse>> GetByIdAsync(string id)
        {
            try
            {
                var entity = await _repository.GetByIdAsync(id);
                if (entity == null)
                {
                    return new BaseResponse<TResponse>
                    {
                        Success = false,
                        ErrorMessage = $"Entity with ID {id} not found."
                    };
                }

                var response = MapEntityToResponse(entity);
                return new BaseResponse<TResponse>
                {
                    Success = true,
                    Value = response
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<TResponse>
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }
        public async Task<BaseResponse<IEnumerable<TResponse>>> GetPaginatedAndFilteredData(int pageNumber, int pageSize, Func<T, bool> filter)
        {
            var data = await _repository.GetPaginatedAndFilteredData(pageNumber, pageSize, filter);
            var response = MapEntitiesToResponse(data.Data);

            return new BaseResponse<IEnumerable<TResponse>>
            {
                Success = true,
                Value = response,
                TotalPages=data.TotalPages,
            };
        }
        public async Task<BaseResponse<IEnumerable<TResponse>>> GetAllAsync()
        {
            try
            {
                var entities = await _repository.GetAllAsync();
                var response = MapEntitiesToResponse(entities);
                return new BaseResponse<IEnumerable<TResponse>>
                {
                    Success = true,
                    Value = response
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<TResponse>>
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        public async Task<BaseResponse<TResponse>> CreateAsync(T entity)
        {
            try
            {
                
                await _repository.AddAsync(entity);
                await _repository.SaveChangesAsync();
                var response = MapEntityToResponse(entity);
                return new BaseResponse<TResponse>
                {
                    Success = true,
                    Value = response
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<TResponse>
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        public async Task<BaseResponse<TResponse>> UpdateAsync(string id, T entity)
        {
            try
            {
                var existingEntity = await _repository.GetByIdAsync(id);
                if (existingEntity == null)
                {
                    return new BaseResponse<TResponse>
                    {
                        Success = false,
                        ErrorMessage = $"Entity with ID {id} not found."
                    };
                }

                _mapper.Map(entity, existingEntity);
                MapEntity(entity, existingEntity);
              await  _repository.UpdateAsync(existingEntity);
                await _repository.SaveChangesAsync();
                var response = MapEntityToResponse(existingEntity);
                return new BaseResponse<TResponse>
                {
                    Success = true,
                    Value = response
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<TResponse>
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        public async Task<BaseResponse<bool>> DeleteAsync(string id)
        {
            try
            {
                var entity = await _repository.GetByIdAsync(id);
                if (entity == null)
                {
                    return new BaseResponse<bool>
                    {
                        Success = false,
                        ErrorMessage = $"Entity with ID {id} not found."
                    };
                }

              await  _repository.RemoveAsync(entity);
                await _repository.SaveChangesAsync();
                return new BaseResponse<bool>
                {
                    Success = true,
                    Value = true
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        protected virtual TResponse MapEntityToResponse(T entity)
        {
            return _mapper.Map<T, TResponse>(entity);
        }



        protected virtual IEnumerable<TResponse> MapEntitiesToResponse(IEnumerable<T> entities)
        {
            return _mapper.Map<IEnumerable<T>, IEnumerable<TResponse>>(entities);
        }

        private void MapEntity(T source, T destination)
        {
            _mapper.Map(source, destination);
        }
    }
}

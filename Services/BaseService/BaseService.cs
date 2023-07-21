using AutoMapper;
using CarWebAPI.Data.Repositores.BaseRepsitory;

namespace CarWebAPI.Services.BaseService
{
    using AutoMapper;
    using Azure;
    using CarWebAPI.Entities.Domain;
    using CarWebAPI.Entities.Domain.Parametre;
    using CarWebAPI.Modules;
    using System.Security.Principal;

    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly IMapper _mapper;

        public BaseService(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<BaseResponse<T>> GetByIdAsync(int id)
        {
            try
            {
                var entity = await _repository.GetByIdAsync(id);
                if (entity == null)
                {
                    return new BaseResponse<T>
                    {
                        Success = false,
                        ErrorMessage = $"Entity with ID {id} not found."
                    };
                }

                var response = MapEntityToResponse(entity);
                return new BaseResponse<T>
                {
                    Success = true,
                    Value = response
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<T>
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }
        public async Task<BaseResponse<IEnumerable<T>>> GetPaginatedAndFilteredData(int pageNumber, int pageSize, Func<T, bool> filter)
        {
            var data = await _repository.GetPaginatedAndFilteredData(pageNumber, pageSize, filter);
            var response = MapEntitiesToResponse(data.Data);

            return new BaseResponse<IEnumerable<T>>
            {
                Success = true,
                Value = response,
                TotalPages=data.TotalPages,
            };
        }
        public async Task<BaseResponse<IEnumerable<T>>> GetAllAsync()
        {
            try
            {
                var entities = await _repository.GetAllAsync();
                var response = MapEntitiesToResponse(entities);
                return new BaseResponse<IEnumerable<T>>
                {
                    Success = true,
                    Value = response
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<T>>
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        public async Task<BaseResponse<T>> CreateAsync(T entity)
        {
            try
            {
                
                await _repository.AddAsync(entity);
                await _repository.SaveChangesAsync();
                var response = MapEntityToResponse(entity);
                return new BaseResponse<T>
                {
                    Success = true,
                    Value = response
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<T>
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        public async Task<BaseResponse<T>> UpdateAsync(int id, T entity)
        {
            try
            {
                var existingEntity = await _repository.GetByIdAsync(id);
                if (existingEntity == null)
                {
                    return new BaseResponse<T>
                    {
                        Success = false,
                        ErrorMessage = $"Entity with ID {id} not found."
                    };
                }
                //var map = MapDTOToEntity (entity,existingEntity);
                _mapper.Map(entity, existingEntity);
                await _repository.UpdateAsync(entity);
                await _repository.SaveChangesAsync();
                var response = MapEntityToResponse(entity);
                return new BaseResponse<T>
                {
                    Success = true,
                    Value = response
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<T>
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        public async Task<BaseResponse<bool>> DeleteAsync(int id)
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

        protected virtual T MapEntityToResponse(T entity)
        {
            return _mapper.Map<T, T>(entity);
        }



        protected virtual IEnumerable<T> MapEntitiesToResponse(IEnumerable<T> entities)
        {
            return _mapper.Map<IEnumerable<T>, IEnumerable<T>>(entities);
        }


        //public async T MapDTOToEntity(T DTO, T existing)
        //{
        //    return await _mapper.Map(DTO, existing);
        //}
        public T MapToNewEntity(T old)
        {
            var newT = _mapper.Map<T>(old);
            return _mapper.Map<T>(newT);
        }

        public Task<BaseResponse<T>> UpdateAsync<T1>(int id, T1 entity)
        {
            throw new NotImplementedException();
        }

        public T MapDTOToEntity(T newEntity, T OldEntity)
        {
            throw new NotImplementedException();
        }
    }
}

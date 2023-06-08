using AutoMapper;
using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain;
using CarWebAPI.Modules;
using CarWebAPI.Services.BaseService;

namespace CarWebAPI.Services.CarService
{
    public class CarService : BaseService<Car, CarModel>, ICarService
    {
        public CarService(IRepository<Car> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

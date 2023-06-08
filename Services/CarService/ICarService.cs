using CarWebAPI.Entities.Domain;
using CarWebAPI.Modules;
using CarWebAPI.Services.BaseService;

namespace CarWebAPI.Services.CarService
{
    public interface ICarService:IBaseService<Car,CarModel>
    {
    }
}

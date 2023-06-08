using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain;

namespace CarWebAPI.Data.Repositores.CarRepository
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(DataContext context) : base(context)
        {
        }
    }
}

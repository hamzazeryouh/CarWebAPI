using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain.Parametre;

namespace CarWebAPI.Data.Repositores.Parameter
{
    public class FuelTypeRepository : Repository<FuelType>, lFuelTypeRepository
    {
        public FuelTypeRepository(DataContext context) : base(context)
        {
        }
    }
}

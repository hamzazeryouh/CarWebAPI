using AutoMapper;
using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;

namespace CarWebAPI.Services.Parameter.FuelTypeService
{
    public class FuelTypeService : BaseService<FuelType, FuelTypeModel>, IFuelTypeService
    {
        public FuelTypeService(IRepository<FuelType> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

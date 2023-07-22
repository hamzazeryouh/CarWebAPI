using AutoMapper;
using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;

namespace CarWebAPI.Services.Parameter.BodyTypeService
{
    public class BodyTypeService : BaseService<BodyType>, IBodyTypeService
    {
        public BodyTypeService(IRepository<BodyType> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

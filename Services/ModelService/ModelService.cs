using AutoMapper;
using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;

namespace CarWebAPI.Services
{
    public class ModelService : BaseService<Model, ModelView>, IModelService
    {
        public ModelService(IRepository<Model> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

using AutoMapper;
using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;

namespace CarWebAPI.Services.Parameter.FeatureService
{
    public class FeatureService : BaseService<Feature, FeatureModel>, IFeatureService
    {
        public FeatureService(IRepository<Feature> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain.Parametre;

namespace CarWebAPI.Data.Repositores
{
    public class FeatureRepository : Repository<Feature>, IFeatureRepository
    {
        public FeatureRepository(DataContext context) : base(context)
        {
        }
    }
}

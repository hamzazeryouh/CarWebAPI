using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain.Parametre;

namespace CarWebAPI.Data.Repositores
{
    public class ModelRepository : Repository<Model>, lModelRepository
    {
        public ModelRepository(DataContext context) : base(context)
        {
        }
    }
}

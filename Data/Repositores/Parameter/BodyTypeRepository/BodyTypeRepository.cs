using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain.Parametre;

namespace CarWebAPI.Data.Repositores.Parameter.BodyTypeRepository
{
    public class BodyTypeRepository : Repository<BodyType>
    {
        public BodyTypeRepository(DataContext context) : base(context)
        {
        }
    }
}

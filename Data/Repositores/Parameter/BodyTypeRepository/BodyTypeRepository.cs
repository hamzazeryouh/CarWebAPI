using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain.Parametre;

namespace CarWebAPI.Data.Repositores.Parameter
{
    public class BodyTypeRepository : Repository<BodyType>, IBodyTypeRepository
    {
        public BodyTypeRepository(DataContext context) : base(context)
        {
        }
    }
}

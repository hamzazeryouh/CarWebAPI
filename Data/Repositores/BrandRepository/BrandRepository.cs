using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain.Parametre;

namespace CarWebAPI.Data.Repositores.BrandRepository
{
    public class BrandRepository : Repository<Brand>, lBrandRepository
    {
        public BrandRepository(DataContext context) : base(context)
        {
        }
    }
}

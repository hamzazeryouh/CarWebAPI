using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain;

namespace CarWebAPI.Data.Repositores.ImagesRepository
{
    public class ImageRepository : Repository<Images>, IImageRepositroy
    {
        public ImageRepository(DataContext context) : base(context)
        {
        }
    }
}

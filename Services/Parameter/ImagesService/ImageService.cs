using AutoMapper;
using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;
using static System.Net.Mime.MediaTypeNames;

namespace CarWebAPI.Services.Parameter.ImagesService
{
    public class ImageService : BaseService<Images, ImageModel>, IImageService
    {
        public ImageService(IRepository<Images> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

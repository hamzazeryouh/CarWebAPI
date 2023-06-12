using AutoMapper;
using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;
namespace CarWebAPI.Services.Parameter
{
    public class ImageService : BaseService<Images, ImageModel>, IImageService
    {
        public ImageService(IRepository<Images> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

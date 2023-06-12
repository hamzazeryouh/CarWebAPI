using CarWebAPI.Entities.Domain;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules;
using CarWebAPI.Services.BaseService;

namespace CarWebAPI.Services.Parameter.BrandService
{
    public interface IBrandService : IBaseService<Brand, BrandModel>
    {
    }
}

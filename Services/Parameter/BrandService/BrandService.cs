using AutoMapper;
using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules;
using CarWebAPI.Services.BaseService;

namespace CarWebAPI.Services.Parameter.BrandService
{
    public class BrandService : BaseService<Brand>, IBrandService
    {
        public BrandService(IRepository<Brand> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

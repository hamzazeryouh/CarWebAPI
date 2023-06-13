using CarWebAPI.Entities.Domain;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules;
using CarWebAPI.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

[Route("api/Brand")]
[ApiController]
public class BrandController : BaseController<Brand, BrandModel>
{
    public BrandController(IBaseService<Brand, BrandModel> service) : base(service)
    {
    }
}



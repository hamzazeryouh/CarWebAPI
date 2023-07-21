using CarWebAPI.Entities.Domain;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

[Route("api/Feature")]
[ApiController]
public class FeatureController : BaseController<Feature, FeatureModel>
{
    public FeatureController(IBaseService<Feature> service) : base(service)
    {
    }
}



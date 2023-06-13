using CarWebAPI.Entities.Domain;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

[Route("api/BodyType")]
[ApiController]
public class BodyTypeController : BaseController<BodyType, BodyTypeModel>
{
    public BodyTypeController(IBaseService<BodyType, BodyTypeModel> service) : base(service)
    {
    }
}



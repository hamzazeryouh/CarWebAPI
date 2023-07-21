using CarWebAPI.Entities.Domain;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

[Route("api/Model")]
[ApiController]
public class ModelController : BaseController<Model, ModelView>
{
    public ModelController(IBaseService<Model> service) : base(service)
    {
    }
}



using CarWebAPI.Entities.Domain;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

[Route("api/Images")]
[ApiController]
public class ImagesController : BaseController<Images, ImageModel>
{
    public ImagesController(IBaseService<Images, ImageModel> service) : base(service)
    {
    }
}



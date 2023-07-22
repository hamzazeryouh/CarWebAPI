using CarWebAPI.Entities.Domain;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

[Route("api/FuelType")]
[ApiController]
public class FuelTypeController : BaseController<FuelType, FuelTypeModel>
{
    public FuelTypeController(IBaseService<FuelType> service) : base(service)
    {
    }
}



using CarWebAPI.Entities.Domain;
using CarWebAPI.Modules;
using CarWebAPI.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

[Route("api/cars")]
[ApiController]
public class CarController : BaseController<Car, CarModel>
{
    public CarController(IBaseService<Car, CarModel> service) : base(service)
    {
    }
}



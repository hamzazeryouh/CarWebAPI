using CarWebAPI.Entities.Domain;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

[Route("api/Transmission")]
[ApiController]
public class TransmissionController : BaseController<Transmission, TransmissioModel>
{
    public TransmissionController(IBaseService<Transmission, TransmissioModel> service) : base(service)
    {
    }
}



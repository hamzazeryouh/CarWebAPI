using AutoMapper;
using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;

namespace CarWebAPI.Services.Parameter.TransmissionService
{
    public class TransmissionService : BaseService<Transmission>, ITransmissionService
    {
        public TransmissionService(IRepository<Transmission> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain.Parametre;

namespace CarWebAPI.Data.Repositores.Parameter
{
    public class TransmissionRepository : Repository<Transmission>, ITransmissionRepository
    {
        public TransmissionRepository(DataContext context) : base(context)
        {
        }
    }
}

using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Entities.Domain.Parametre;

namespace CarWebAPI.Data.Repositores.TransmissionRepository
{
    public class TransmissionRepository : Repository<Transmission>
    {
        public TransmissionRepository(DataContext context) : base(context)
        {
        }
    }
}

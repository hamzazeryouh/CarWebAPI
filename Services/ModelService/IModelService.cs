using CarWebAPI.Entities.Domain;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules;
using CarWebAPI.Modules.Parametre;
using CarWebAPI.Services.BaseService;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarWebAPI.Services
{
    public interface IModelService:IBaseService<Entities.Domain.Parametre.Model, ModelView>
    {
    }
}

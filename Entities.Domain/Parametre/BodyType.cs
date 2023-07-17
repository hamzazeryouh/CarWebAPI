using System.Runtime.CompilerServices;

namespace CarWebAPI.Entities.Domain.Parametre
{
    public class BodyType:IEntity
    {
       
        public BodyType()
        {
            
            
        }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

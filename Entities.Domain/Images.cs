using System.Security.Principal;

namespace CarWebAPI.Entities.Domain
{
    public class Images: IEntity
    {
        public Images()
        {
            
        } 
      public  string Url { get; set; }
    }
}

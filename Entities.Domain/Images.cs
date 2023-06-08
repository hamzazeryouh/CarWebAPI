using System.Security.Principal;

namespace CarWebAPI.Entities.Domain
{
    public class Images: IEntity<string>
    {
        public Images()
        {
            this.Id = Guid.NewGuid().ToString();
        } 
      public  string Url { get; set; }
    }
}

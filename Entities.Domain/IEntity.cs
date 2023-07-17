using Microsoft.EntityFrameworkCore;

namespace CarWebAPI.Entities.Domain
{
    public class IEntity
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }= DateTimeOffset.Now;
        public DateTimeOffset? LastModifiedOn { get; set; }

        
    }
}

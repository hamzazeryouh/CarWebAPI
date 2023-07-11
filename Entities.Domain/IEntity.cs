namespace CarWebAPI.Entities.Domain
{
    public class IEntity
    {
        public string Id { get; set; } =Guid.NewGuid().ToString();
        public DateTimeOffset CreatedOn { get; set; }= DateTimeOffset.Now;
        public DateTimeOffset? LastModifiedOn { get; set; }

        
    }
}

namespace CarWebAPI.Entities.Domain
{
    public class IEntity<Tkey>
    {
        public Tkey Id { get; set; }  
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset? LastModifiedOn { get; set; }

        
    }
}

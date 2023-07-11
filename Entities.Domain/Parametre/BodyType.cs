namespace CarWebAPI.Entities.Domain.Parametre
{
    public class BodyType:IEntity
    {
        public BodyType()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

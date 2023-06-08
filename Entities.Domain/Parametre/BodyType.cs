namespace CarWebAPI.Entities.Domain.Parametre
{
    public class BodyType:IEntity<string>
    {
        public BodyType()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

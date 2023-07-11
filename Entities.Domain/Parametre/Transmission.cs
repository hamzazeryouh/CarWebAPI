namespace CarWebAPI.Entities.Domain.Parametre
{
    public class Transmission:IEntity
    {
        public Transmission() { 
        Id=Guid.NewGuid().ToString();
        }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

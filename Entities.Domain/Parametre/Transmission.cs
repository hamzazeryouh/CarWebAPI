namespace CarWebAPI.Entities.Domain.Parametre
{
    public class Transmission:IEntity<string>
    {
        public Transmission() { 
        this.Id=Guid.NewGuid().ToString();
        }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

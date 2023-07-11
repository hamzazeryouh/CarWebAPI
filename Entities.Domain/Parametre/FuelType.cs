namespace CarWebAPI.Entities.Domain.Parametre
{
    public class FuelType:IEntity
    {
        public FuelType() {
        this.Id=Guid.NewGuid().ToString();
        }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

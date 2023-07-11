namespace CarWebAPI.Entities.Domain.Parametre
{
    public class Model:IEntity
    {
        public Model() {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}

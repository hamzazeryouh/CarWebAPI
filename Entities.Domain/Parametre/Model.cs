namespace CarWebAPI.Entities.Domain.Parametre
{
    public class Model:IEntity
    {
        public Model() {
            
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}

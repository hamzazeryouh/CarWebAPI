namespace CarWebAPI.Entities.Domain.Parametre
{
    public class Feature : IEntity
    {
        public Feature()
        {
           
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string icon { get; set; }
    }
}

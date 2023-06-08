namespace CarWebAPI.Entities.Domain.Parametre
{
    public class Feature : IEntity<string>
    {
        public Feature()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string icon { get; set; }
    }
}

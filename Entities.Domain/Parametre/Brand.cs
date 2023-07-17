namespace CarWebAPI.Entities.Domain.Parametre
{
    public class Brand:IEntity
    {
        public Brand()
    {
            
        }
    public string Name { get; set; }
    public string Description { get; set; }

    public ICollection<Model> models { get; set; }
}
}

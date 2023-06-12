using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Entities.Domain;

namespace CarWebAPI.Modules
{
    public class CarModel
    {
        public Brand? Brand { get; set; }
        public Model? Model { get; set; }
        public int? Year { get; set; }
        public string? Color { get; set; }
        public BodyType? BodyType { get; set; }
        public Transmission? Transmission { get; set; }

        public FuelType? FuelType { get; set; }
        public int? SeatingCapacity { get; set; }
        public int? LuggageCapacity { get; set; }
        public ICollection<Feature>? Features { get; set; }
        public ICollection<Images>? Images { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public decimal Discount { get; set; }
        public string? Description { get; set; }
        public User? Agence { get; set; }
    }
}

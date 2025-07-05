using VehicleSystem.Domain.Entities;

namespace VehicleSystem.API.Models
{
    public class VehicleSearchResultViewModel
    {
        public int year { get; set; }
        public List<Model> models { get; set; } = new List<Model>();
        public List<VehicleType> vehicleTypes { get; set; } = new List<VehicleType>();

        public int? MakeId { get; set; }
        public int? Year { get; set; }

        public List<Make> Makes { get; set; } = new();
        public List<VehicleModelCard> Models { get; set; } = new();
    }

    public class VehicleModelCard
    {
        public string MakeName { get; set; } = "";
        public string ModelName { get; set; } = "";
        public string VehicleType { get; set; } = "";
    }
}

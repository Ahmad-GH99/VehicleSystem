using VehicleSystem.Domain.Entities;

namespace VehicleSystem.API.Models
{
    public class VehicleSearchResultViewModel
    {

        public int? MakeId { get; set; }
        public int? Year { get; set; }
        public List<VehicleType> vehicleTypes { get; set; } = new List<VehicleType>();
        public List<Make> Makes { get; set; } = new();
        public List<VehicleModelCard> Models { get; set; } = new();
    }


}

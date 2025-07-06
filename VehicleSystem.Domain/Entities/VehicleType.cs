using Newtonsoft.Json;

namespace VehicleSystem.Domain.Entities
{
    public class VehicleType
    {
        public int VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
        public int MakeId { get; set; }
        public string MakeName { get; set; }
    }
}

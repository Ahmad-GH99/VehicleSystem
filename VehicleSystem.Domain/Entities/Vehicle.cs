using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem.Domain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string MakeName { get; set; }

        [JsonProperty("Model_ID")]
        public int ModelId { get; set; }

        [JsonProperty("Model_Name")]
        public string ModelName { get; set; }
        public int Year { get; set; }
        public int? VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
    }
}

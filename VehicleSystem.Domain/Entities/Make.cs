using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VehicleSystem.Domain.Entities
{
    public class Make
    {
        [JsonPropertyName("Make_ID")]
        public int ID { get; set; }

        [JsonPropertyName("Make_Name")]
        public string MakeName { get; set; }
    }
}

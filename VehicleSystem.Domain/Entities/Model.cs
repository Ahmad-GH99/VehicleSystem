﻿
using System.Text.Json.Serialization;


namespace VehicleSystem.Domain.Entities
{
    public class Model
    {
        [JsonPropertyName("Model_ID")]
        public int ModelId { get; set; }
        [JsonPropertyName("Model_Name")]
        public string ModelName { get; set; }

        [JsonPropertyName("Make_ID")]
        public int MakeId { get; set; }
        [JsonPropertyName("Make_Name")]
        public string MakeName { get; set; }

    }
}

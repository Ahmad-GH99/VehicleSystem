using System.Text.Json.Serialization;

namespace VehicleSystem.Domain.Entities
{
    public class Make
    {
        [JsonPropertyName("Make_ID")]
        public int Id { get; set; }

        [JsonPropertyName("Make_Name")]
        public string MakeName { get; set; }
    }
}

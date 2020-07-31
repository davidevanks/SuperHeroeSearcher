using Newtonsoft.Json;

namespace SuperHeroe.Data.Models
{
    public class Biography
    {
        [JsonProperty("full-name")]
        public string FullName { get; set; }
        [JsonProperty("alter-egos")]
        public string AlterEgo { get; set; }
        [JsonProperty("aliases")]
        public string[] Aliases { get; set; }
        
        [JsonProperty("place-of-birth")]
        public string PlaceOfBirth { get; set; }
        
        [JsonProperty("first-appearance")]
        public string firstappearance { get; set; }
        [JsonProperty("publisher")]
        public string Publisher { get; set; }
        [JsonProperty("alignment")]
        public string Alignment { get; set; }
    }
}
using Newtonsoft.Json;

namespace SuperHeroe.Data.Models
{
    public class Appearance
    {
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("race")]
        public string Race { get; set; }
        [JsonProperty("height")]
        public string[] Height { get; set; }
        [JsonProperty("weight")]
        public string[] Weight { get; set; }

        [JsonProperty("eye-color")]
        public string EyeColor { get; set; }
        [JsonProperty("hair-color")]
        public string HairColor { get; set; }
    }
}
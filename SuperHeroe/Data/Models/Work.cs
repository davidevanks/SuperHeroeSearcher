using Newtonsoft.Json;

namespace SuperHeroe.Data.Models
{
    public class Work
    {
        // "occupation": "-",
        //"base": "21st Century Gotham City"
        [JsonProperty("occupation")]
        public string Occupation { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }
    }
}
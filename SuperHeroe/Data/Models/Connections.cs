using Newtonsoft.Json;

namespace SuperHeroe.Data.Models
{
    public class Connections
    {
        
        [JsonProperty("group-affiliation")]
        public string GroupAffiliation { get; set; }
        [JsonProperty("relatives")]
        public string Relatives { get; set; }
    }
}
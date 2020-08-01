using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroe.Data.Models
{
    public class Heroe
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("powerstats")]
        public Powerstats Powerstats { get; set; }
        [JsonProperty("biography")]
        public Biography Biography { get; set; }
        [JsonProperty("appearance")]
        public Appearance Appearance { get; set; }
        [JsonProperty("work")]
        public Work Work { get; set; }
        [JsonProperty("connections")]
        public Connections Connections { get; set; }

        [JsonProperty("image")]
        public ImageUrl Image { get; set; }
    }
}

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
        public List<Powerstats> Powerstats { get; set; }
        [JsonProperty("biography")]
        public List<Biography> Biography { get; set; }
        [JsonProperty("appearance")]
        public List<Appearance> Appearance { get; set; }
        [JsonProperty("work")]
        public List<Work> Work { get; set; }
        [JsonProperty("connections")]
        public List<Connections> Connections { get; set; }

        [JsonProperty("image")]
        public List<ImageUrl> Image { get; set; }
    }
}

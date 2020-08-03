using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroe.Data.Models
{
    /// <summary>
    /// Clase utilizada para recibir el response.
    /// </summary>
    public class ResponseSearch
    {
        [JsonProperty("response")]
        public string MessageResponse { get; set; }
        [JsonProperty("results-for")]
        public string Resultsfor  { get; set; }
        [JsonProperty("results")]
        public List<Heroe> ListHeroes { get; set; }
        [JsonProperty("error")]
        public string MessageError { get; set; }
        public string ValueSearch { get; set; }
        public Task<Heroe> HeroeDetail { get; set; }

    }
}

﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroe.Data.Models
{
    public class ImageUrl
    {
        [JsonProperty("base")]
        public string Url { get; set; }
    }
}

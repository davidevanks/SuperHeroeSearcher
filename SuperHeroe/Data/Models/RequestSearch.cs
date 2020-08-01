using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroe.Data.Models
{
    public class RequestSearch
    {
        [Required(ErrorMessage ="Please write a name of a superheroe or villian")]
        [MinLength(1)]
        public string ValueSearch { get; set; }

        public int Indicator { get; set; }

    }
}

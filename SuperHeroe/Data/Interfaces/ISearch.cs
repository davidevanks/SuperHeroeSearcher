using SuperHeroe.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroe.Data.Interfaces
{
   public interface ISearch
    {
        Task<ResponseSearch> Heroes(string ValueSearch);

        Task<Heroe> HeroesDetails(int Id);

    }
}

using Newtonsoft.Json;
using SuperHeroe.Data.Interfaces;
using SuperHeroe.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SuperHeroe.Data.Repositories
{
    public class SearchRepository: ISearch
    {

       public async Task<ResponseSearch> Heroes(string ValueSearch)
        {
            ResponseSearch Heroes = new ResponseSearch();

            using (var httpclient = new HttpClient())
            {

                using (var response = httpclient.GetAsync("https://superheroapi.com/api/10221230922474980/search/"+ValueSearch))
                {
                    string jsonResponse = await response.Result.Content.ReadAsStringAsync();
                    Heroes = JsonConvert.DeserializeObject<ResponseSearch>(jsonResponse);
                    Heroes.ValueSearch = ValueSearch;

                }

            }

            return Heroes;
        }

    }
}

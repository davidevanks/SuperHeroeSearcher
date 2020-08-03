using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using SuperHeroe.Data.Interfaces;
using SuperHeroe.Data.Models;
using SuperHeroe.Models;

namespace SuperHeroe.Controllers
{
    
    public class HomeController : Controller
    {
       
        private readonly ISearch _search;
       
        private readonly IMemoryCache _memoryCache;
     

        public HomeController( ISearch SearchRepository, IMemoryCache memoryCache)
        {
         
            _search = SearchRepository;
            _memoryCache = memoryCache;
           
        }
        
        public IActionResult Index(string searchString)
        {
            var cacheKey = "";
            searchString = searchString == null ? cacheKey = "" : cacheKey=searchString;
            
            ViewData["searchString"] = searchString;
           
             HttpContext.Session.SetString("searchString", cacheKey);

            if (!_memoryCache.TryGetValue(cacheKey,out Task<ResponseSearch> Heroes))
            {
                if (searchString!=null)
                {
                    Heroes = _search.Heroes(searchString);
                }
                

                var cacheExpirationsOptions =
                    new MemoryCacheEntryOptions
                    {
                        AbsoluteExpiration = DateTime.Now.AddHours(1),
                        Priority = CacheItemPriority.Normal,
                        SlidingExpiration=TimeSpan.FromMinutes(10)
                    };

                _memoryCache.Set(cacheKey, Heroes, cacheExpirationsOptions);
            }
            
            return View(Heroes);
        }

       


    }
}

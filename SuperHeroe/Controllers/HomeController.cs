using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SuperHeroe.Data.Interfaces;
using SuperHeroe.Data.Models;
using SuperHeroe.Models;

namespace SuperHeroe.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISearch _search;

     

        public HomeController(ILogger<HomeController> logger, ISearch SearchRepository)
        {
            _logger = logger;
            _search = SearchRepository;
        }
        //[HttpGet]
        //[Route("Index/{q}")]
        public IActionResult Index(string searchString)
        {
            ViewData["searchString"] = searchString;
            HttpContext.Session.SetString("searchString", "ironman");
            Task<ResponseSearch> Heroes;
            Heroes = _search.Heroes(searchString);
            return View(Heroes);
        }

    
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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

        public IActionResult Index()
        {


            Task<ResponseSearch> Response;
            Response = _search.Heroes("batman");
            return View(Response);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

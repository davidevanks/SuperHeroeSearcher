using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperHeroe.Data.Interfaces;
using SuperHeroe.Data.Repositories;
using SuperHeroe.Data.Models;
using Microsoft.AspNetCore.Http;

namespace SuperHeroe.Controllers
{
    public class HeroeController : Controller
    {
        private readonly ISearch _search;
        [BindProperty]
        public Heroe Heroe { get; set; }

        public HeroeController(ISearch SearchRepository)
        {
            _search = SearchRepository;
            
        }

        public IActionResult Index(string ValueSearch)
        {
            return new RedirectToActionResult("Index", "Home", ValueSearch);

        }

        [HttpGet("character/{id}")]
        public IActionResult DetailsHeroes(int Id)
        {

            Task<Heroe> Response;
            Response = _search.HeroesDetails(Id);
            Response.Result.ValueSearch = HttpContext.Session.GetString("searchString");

            if(Response.Result.Id ==null)
            {
                ViewBag.ErrorMessage = "Sorry, the resource you requested could not be found!";
                ViewBag.ErrorHeader = "HEROE O VILLANO NOT FOUND";
                return View("_NotFound");
            }
            return View(Response);
        }

    }
}

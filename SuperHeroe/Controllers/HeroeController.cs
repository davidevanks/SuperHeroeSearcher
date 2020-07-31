﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperHeroe.Data.Interfaces;
using SuperHeroe.Data.Repositories;
using SuperHeroe.Data.Models;
namespace SuperHeroe.Controllers
{
    public class HeroeController : Controller
    {
        private readonly ISearch _search;

        public HeroeController(ISearch Search, SearchRepository SearchRepository)
        {
            _search = SearchRepository;
            
        }

        public IActionResult Index()
        {
            return View();
            
        }


    }
}

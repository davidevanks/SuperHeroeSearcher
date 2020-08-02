using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeroe.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttStatusCodeHandler(int statusCode)
        {

            switch(statusCode)
            {

                case 404:
                    ViewBag.ErrorMessage = "Sorry, the resource you requested could not be found!";
                    ViewBag.ErrorHeader = "404 NOT FOUND";
                    break;
            }
            return View("_NotFound");
        }
    }
}

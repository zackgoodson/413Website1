using Microsoft.AspNetCore.Mvc;
using _413Website1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace _413Website1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Gets the Calculator form view
        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }

        // Overloading to post the form object into the model
        [HttpPost]
        public IActionResult Calculator (CalculateModel model)
        {
            return View();
        }
    }
}

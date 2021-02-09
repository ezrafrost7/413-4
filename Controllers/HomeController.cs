using _413_4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _413_4.Models;

namespace _413_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //controller to view the home page
        public IActionResult Index()
        {
            return View();
        }
        //controller to view the SubmitNew page
        [HttpGet]
        public IActionResult SubmitNew()
        {
            return View();
        }
        //controller for when the form is submitted
        [HttpPost]
        public IActionResult SubmitNew(RestSubmit restaurant)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddEntry(restaurant);
                Response.Redirect("ViewNew");
            }
            return View();
        }
        //controller to view the page with the submissions
        public IActionResult ViewNew()
        {
            return View(TempStorage.Entries);
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

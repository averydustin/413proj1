using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IS413Project1.Models;

namespace IS413Project1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Index View (Home page)
        public IActionResult Index()
        {
            return View();
        }


        //Sign Up View on GET (when page is originally loaded)
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        //Sign up View on POST (when time is submitted)
        //(still need to pass method to this from model. Something like "Add time")
        [HttpPost]
        public IActionResult SignUp(int? time)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }
            else
            {
                return View();
            }
        }

        //View for inputting individual information GET (when page is loaded)
         [HttpGet]
         public IActionResult TimeInput()
         {
             return View();
         }

        //POST view for individual information (still need to pass parameters here based on model)
        [HttpPost]
        public IActionResult TimeInput(Appointment appointment)
        {
            string time = appointment.ApptTime;
            return View("SignUp", time);
        }

        //Page for viewing all appointments
        [HttpGet]
        public IActionResult ViewApppointments()
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

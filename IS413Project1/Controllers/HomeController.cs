using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IS413Project1.Models;
using IS413Project1.Models.ViewModels;

namespace IS413Project1.Controllers
{
    public class HomeController : Controller
    {

        private AppointmentDBContext context { get; set; }

        public HomeController(AppointmentDBContext cxt)
        {
            context = cxt;
        }
        //Index View (Home page)
        public IActionResult Index()
        {
            return View();
        }

        //Sign Up View on GET (when page is originally loaded)
        [HttpGet]
        public IActionResult SignUp(int TimeSlotID)
        {
            TimeSlot timeslot = context.TimeSlots.Where(t => t.TimeSlotID == TimeSlotID).FirstOrDefault();
            ViewBag.DayTime = timeslot.Day + " " + timeslot.Time;
            ViewBag.TimeSlotID = timeslot.TimeSlotID;
            return View();
        }

        //Sign up View on POST (when time is submitted)
        //(still need to pass method to this from model. Something like "Add time")
        [HttpPost]
        public IActionResult SignUp(Appointment appointment, int TimeSlotID)
        {
            if (ModelState.IsValid)
            {
                TimeSlot timeslot = context.TimeSlots.Where(t => t.TimeSlotID == TimeSlotID).FirstOrDefault();
                timeslot.ApptID = appointment.ApptID;
                context.Appointments.Add(appointment);
                context.SaveChanges();
                string confirmation = "Your appointment was scheduled!";
                ViewBag.Confirm = confirmation;
                return View("Index", confirmation);
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
            return View(new TimeSlotViewModel
            {
                TimeSlots = context.TimeSlots.Where(t => t.ApptID == null)
            }
                )  ;
        }

        //POST view for individual information (still need to pass parameters here based on model)
        [HttpPost]
        public IActionResult TimeInput(int TimeSlotID)
        {
           
            if (ModelState.IsValid)
            {
                return RedirectToAction("SignUp",new { TimeSlotID = TimeSlotID });
            }
            else
            {
                return View();
            }

        }

        //Page for viewing all appointments
        [HttpGet]
        public IActionResult ViewAppointments()
        {
            return View(new TimeSlotViewModel
            {
                Appointments = context.Appointments
            }) ;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using TicketReservation.Models;
using System.Web.Mvc;


namespace TicketReservation.Controllers
{
    public class ReservationTypeController : Controller 
    {
        // GET: ReservationType
        public ActionResult Train()
        {
            
            
            return View();
        }
        
        [HttpPost]
        public ActionResult Train(FormCollection form)
        {
            var source = form["source"].ToString();
            var destination = form["destination"].ToString();
            ViewBag.Source = source;
            ViewBag.Destination = destination;
            TempData["source"] = form["source"];
            TempData["destination"] = form["destination"];
            return View();
        }
        public ActionResult Bus()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Bus(FormCollection form)
        {
            var source = form["source"].ToString();
            var destination = form["destination"].ToString();
            ViewBag.Source = source;
            ViewBag.Destination = destination;
            TempData["source"] = form["source"];
            TempData["destination"] = form["destination"];
            return View();
        }
        public ActionResult Plane()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Plane(FormCollection form)
        {
            var source = form["source"].ToString();
            var destination = form["destination"].ToString();
            ViewBag.Source = source;
            ViewBag.Destination = destination;
            TempData["source"] = form["source"];
            TempData["destination"] = form["destination"];
            return View();
        }
    }
}
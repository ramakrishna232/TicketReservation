using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketReservation.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ReservationList()
        {
            return View();
        }
        public ActionResult ACList()
        {
            return View();
        }
        public ActionResult SLList()
        {
            return View();
        }
        public ActionResult SSList()
        {
            return View();
        }
        public ActionResult BusList()
        {
            return View(); 

        }
        public ActionResult BusinessList()
        {
            return View();
        }
        public ActionResult EconomyList()
        {
            return View();
        }
                
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketReservation.Models;
namespace TicketReservation.Controllers
{
    public class RetriveController : Controller
    {
        // GET: Retrive
        
        public ActionResult Index(string source,string destination)
        {

            
            Train obj1 = new Train();
            List<Train> li = obj1.getTrains(source,destination);

            return View(li.ToList());
        }
        public ActionResult booking()
        {
            return View();
        }
       public ActionResult PassengerView()
        {
            
            return View();
        }
    }
}
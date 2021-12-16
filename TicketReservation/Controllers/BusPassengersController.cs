using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TicketReservation.Models;

namespace TicketReservation.Controllers
{
    public class BusPassengersController : Controller
    {
        private BusReservationEntities db = new BusReservationEntities();

        // GET: BusPassengers
        public ActionResult Index()
        {
            return View(db.BusPassengers.ToList());
        }

        // GET: BusPassengers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusPassenger busPassenger = db.BusPassengers.Find(id);
            if (busPassenger == null)
            {
                return HttpNotFound();
            }
            return View(busPassenger);
        }

        // GET: BusPassengers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusPassengers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Age,Gender,Sno")] BusPassenger busPassenger)
        {
            if (ModelState.IsValid)
            {
                db.BusPassengers.Add(busPassenger);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(busPassenger);
        }

        // GET: BusPassengers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusPassenger busPassenger = db.BusPassengers.Find(id);
            if (busPassenger == null)
            {
                return HttpNotFound();
            }
            return View(busPassenger);
        }

        // POST: BusPassengers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,Age,Gender,Sno")] BusPassenger busPassenger)
        {
            if (ModelState.IsValid)
            {
                db.Entry(busPassenger).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(busPassenger);
        }

        // GET: BusPassengers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusPassenger busPassenger = db.BusPassengers.Find(id);
            if (busPassenger == null)
            {
                return HttpNotFound();
            }
            return View(busPassenger);
        }

        // POST: BusPassengers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BusPassenger busPassenger = db.BusPassengers.Find(id);
            db.BusPassengers.Remove(busPassenger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Payment()
        {
            return View();
        }
        public ActionResult BusPassengerDetail()
        {
            return View(db.BusPassengers.ToList());
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

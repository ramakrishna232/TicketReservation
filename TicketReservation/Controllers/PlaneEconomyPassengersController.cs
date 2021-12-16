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
    public class PlaneEconomyPassengersController : Controller
    {
        private PlaneEcoReservationEntities db = new PlaneEcoReservationEntities();

        // GET: PlaneEconomyPassengers
        public ActionResult Index()
        {
            return View(db.PlaneEconomyPassengers.ToList());
        }

        // GET: PlaneEconomyPassengers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlaneEconomyPassenger planeEconomyPassenger = db.PlaneEconomyPassengers.Find(id);
            if (planeEconomyPassenger == null)
            {
                return HttpNotFound();
            }
            return View(planeEconomyPassenger);
        }

        // GET: PlaneEconomyPassengers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlaneEconomyPassengers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Age,Gender,Sno")] PlaneEconomyPassenger planeEconomyPassenger)
        {
            if (ModelState.IsValid)
            {
                db.PlaneEconomyPassengers.Add(planeEconomyPassenger);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(planeEconomyPassenger);
        }

        // GET: PlaneEconomyPassengers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlaneEconomyPassenger planeEconomyPassenger = db.PlaneEconomyPassengers.Find(id);
            if (planeEconomyPassenger == null)
            {
                return HttpNotFound();
            }
            return View(planeEconomyPassenger);
        }

        // POST: PlaneEconomyPassengers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,Age,Gender,Sno")] PlaneEconomyPassenger planeEconomyPassenger)
        {
            if (ModelState.IsValid)
            {
                db.Entry(planeEconomyPassenger).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(planeEconomyPassenger);
        }

        // GET: PlaneEconomyPassengers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlaneEconomyPassenger planeEconomyPassenger = db.PlaneEconomyPassengers.Find(id);
            if (planeEconomyPassenger == null)
            {
                return HttpNotFound();
            }
            return View(planeEconomyPassenger);
        }

        // POST: PlaneEconomyPassengers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlaneEconomyPassenger planeEconomyPassenger = db.PlaneEconomyPassengers.Find(id);
            db.PlaneEconomyPassengers.Remove(planeEconomyPassenger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Payment()
        {
            return View();
        }
        public ActionResult Passenger()
        {
            return View(db.PlaneEconomyPassengers.ToList());
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

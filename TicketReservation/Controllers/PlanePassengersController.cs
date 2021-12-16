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
    public class PlanePassengersController : Controller
    {
        private PlaneReservationEntities db = new PlaneReservationEntities();

        // GET: PlanePassengers
        public ActionResult Index()
        {
            return View(db.PlanePassengers.ToList());
        }

        // GET: PlanePassengers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanePassenger planePassenger = db.PlanePassengers.Find(id);
            if (planePassenger == null)
            {
                return HttpNotFound();
            }
            return View(planePassenger);
        }

        // GET: PlanePassengers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlanePassengers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Age,Gender,Sno")] PlanePassenger planePassenger)
        {
            if (ModelState.IsValid)
            {
                db.PlanePassengers.Add(planePassenger);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(planePassenger);
        }

        // GET: PlanePassengers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanePassenger planePassenger = db.PlanePassengers.Find(id);
            if (planePassenger == null)
            {
                return HttpNotFound();
            }
            return View(planePassenger);
        }

        // POST: PlanePassengers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,Age,Gender,Sno")] PlanePassenger planePassenger)
        {
            if (ModelState.IsValid)
            {
                db.Entry(planePassenger).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(planePassenger);
        }

        // GET: PlanePassengers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanePassenger planePassenger = db.PlanePassengers.Find(id);
            if (planePassenger == null)
            {
                return HttpNotFound();
            }
            return View(planePassenger);
        }

        // POST: PlanePassengers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlanePassenger planePassenger = db.PlanePassengers.Find(id);
            db.PlanePassengers.Remove(planePassenger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Payment()
        {
            return View();
        }
        public ActionResult BusinessPassengerDetail()
        {
            return View(db.PlanePassengers.ToList());
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

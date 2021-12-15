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
    public class SLPassengersController : Controller
    {
        private SLReservationEntities db = new SLReservationEntities();

        // GET: SLPassengers
        public ActionResult Index()
        {
            return View(db.SLPassengers.ToList());
        }

        // GET: SLPassengers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SLPassenger sLPassenger = db.SLPassengers.Find(id);
            if (sLPassenger == null)
            {
                return HttpNotFound();
            }
            return View(sLPassenger);
        }

        // GET: SLPassengers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SLPassengers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Age,Gender,Sno")] SLPassenger sLPassenger)
        {
            if (ModelState.IsValid)
            {
                db.SLPassengers.Add(sLPassenger);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sLPassenger);
        }

        // GET: SLPassengers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SLPassenger sLPassenger = db.SLPassengers.Find(id);
            if (sLPassenger == null)
            {
                return HttpNotFound();
            }
            return View(sLPassenger);
        }

        // POST: SLPassengers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,Age,Gender,Sno")] SLPassenger sLPassenger)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sLPassenger).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sLPassenger);
        }

        // GET: SLPassengers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SLPassenger sLPassenger = db.SLPassengers.Find(id);
            if (sLPassenger == null)
            {
                return HttpNotFound();
            }
            return View(sLPassenger);
        }

        // POST: SLPassengers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SLPassenger sLPassenger = db.SLPassengers.Find(id);
            db.SLPassengers.Remove(sLPassenger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Payment()
        {
            return View();
        }
        public ActionResult SLPassengerDetail()
        {
            return View(db.SLPassengers.ToList());
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

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
    public class SSPassengersController : Controller
    {
        private SSReservationEntities db = new SSReservationEntities();

        // GET: SSPassengers
        public ActionResult Index()
        {
            return View(db.SSPassengers.ToList());
        }

        // GET: SSPassengers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SSPassenger sSPassenger = db.SSPassengers.Find(id);
            if (sSPassenger == null)
            {
                return HttpNotFound();
            }
            return View(sSPassenger);
        }

        // GET: SSPassengers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SSPassengers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Age,Gender,Sno")] SSPassenger sSPassenger)
        {
            if (ModelState.IsValid)
            {
                db.SSPassengers.Add(sSPassenger);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sSPassenger);
        }

        // GET: SSPassengers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SSPassenger sSPassenger = db.SSPassengers.Find(id);
            if (sSPassenger == null)
            {
                return HttpNotFound();
            }
            return View(sSPassenger);
        }

        // POST: SSPassengers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,Age,Gender,Sno")] SSPassenger sSPassenger)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sSPassenger).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sSPassenger);
        }

        // GET: SSPassengers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SSPassenger sSPassenger = db.SSPassengers.Find(id);
            if (sSPassenger == null)
            {
                return HttpNotFound();
            }
            return View(sSPassenger);
        }

        // POST: SSPassengers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SSPassenger sSPassenger = db.SSPassengers.Find(id);
            db.SSPassengers.Remove(sSPassenger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Payment()
        {
            return View();
        }
        public ActionResult SSPassenger()
        {
            return View(db.SSPassengers.ToList());
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Simorgh.Models;

namespace Simorgh.Controllers
{   
    public class ReservationsController : Controller
    {
        private SimorghContext context = new SimorghContext();

        //
        // GET: /Reservations/

        public ViewResult Index()
        {
            return View(context.Reservations.Include(reservation => reservation.ReservationItems).ToList());
        }

        //
        // GET: /Reservations/Details/5

        public ViewResult Details(int id)
        {
            Reservation reservation = context.Reservations.Single(x => x.ReservationId == id);
            return View(reservation);
        }

        //
        // GET: /Reservations/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Reservations/Create

        [HttpPost]
        public ActionResult Create(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                context.Reservations.Add(reservation);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(reservation);
        }
        
        //
        // GET: /Reservations/Edit/5
 
        public ActionResult Edit(int id)
        {
            Reservation reservation = context.Reservations.Single(x => x.ReservationId == id);
            return View(reservation);
        }

        //
        // POST: /Reservations/Edit/5

        [HttpPost]
        public ActionResult Edit(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                context.Entry(reservation).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reservation);
        }

        //
        // GET: /Reservations/Delete/5
 
        public ActionResult Delete(int id)
        {
            Reservation reservation = context.Reservations.Single(x => x.ReservationId == id);
            return View(reservation);
        }

        //
        // POST: /Reservations/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Reservation reservation = context.Reservations.Single(x => x.ReservationId == id);
            context.Reservations.Remove(reservation);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
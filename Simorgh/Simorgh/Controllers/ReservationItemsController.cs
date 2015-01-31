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
    public class ReservationItemsController : Controller
    {
        private SimorghContext context = new SimorghContext();

        //
        // GET: /ReservationItems/

        public ViewResult Index()
        {
            return View(context.ReservationItems.ToList());
        }

        //
        // GET: /ReservationItems/Details/5

        public ViewResult Details(int id)
        {
            ReservationItem reservationitem = context.ReservationItems.Single(x => x.ReservationItemId == id);
            return View(reservationitem);
        }

        //
        // GET: /ReservationItems/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /ReservationItems/Create

        [HttpPost]
        public ActionResult Create(ReservationItem reservationitem)
        {
            if (ModelState.IsValid)
            {
                context.ReservationItems.Add(reservationitem);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(reservationitem);
        }
        
        //
        // GET: /ReservationItems/Edit/5
 
        public ActionResult Edit(int id)
        {
            ReservationItem reservationitem = context.ReservationItems.Single(x => x.ReservationItemId == id);
            return View(reservationitem);
        }

        //
        // POST: /ReservationItems/Edit/5

        [HttpPost]
        public ActionResult Edit(ReservationItem reservationitem)
        {
            if (ModelState.IsValid)
            {
                context.Entry(reservationitem).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reservationitem);
        }

        //
        // GET: /ReservationItems/Delete/5
 
        public ActionResult Delete(int id)
        {
            ReservationItem reservationitem = context.ReservationItems.Single(x => x.ReservationItemId == id);
            return View(reservationitem);
        }

        //
        // POST: /ReservationItems/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ReservationItem reservationitem = context.ReservationItems.Single(x => x.ReservationItemId == id);
            context.ReservationItems.Remove(reservationitem);
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
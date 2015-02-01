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
    public class RatingsController : Controller
    {
        private SimorghContext context = new SimorghContext();

        //
        // GET: /Ratings/

        public ViewResult Index()
        {
            return View(context.Ratings.ToList());
        }

        //
        // GET: /Ratings/Details/5

        public ViewResult Details(int id)
        {
            Rating rating = context.Ratings.Single(x => x.RatingId == id);
            return View(rating);
        }

        //
        // GET: /Ratings/Create

        public ActionResult Create()
        {
            ViewBag.PossibleHotels = context.Hotels;
            return View();
        } 

        //
        // POST: /Ratings/Create

        [HttpPost]
        public ActionResult Create(Rating rating)
        {
            if (ModelState.IsValid)
            {
                context.Ratings.Add(rating);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleHotels = context.Hotels;
            return View(rating);
        }
        
        //
        // GET: /Ratings/Edit/5
 
        public ActionResult Edit(int id)
        {
            Rating rating = context.Ratings.Single(x => x.RatingId == id);
            ViewBag.PossibleHotels = context.Hotels;
            return View(rating);
        }

        //
        // POST: /Ratings/Edit/5

        [HttpPost]
        public ActionResult Edit(Rating rating)
        {
            if (ModelState.IsValid)
            {
                context.Entry(rating).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleHotels = context.Hotels;
            return View(rating);
        }

        //
        // GET: /Ratings/Delete/5
 
        public ActionResult Delete(int id)
        {
            Rating rating = context.Ratings.Single(x => x.RatingId == id);
            return View(rating);
        }

        //
        // POST: /Ratings/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Rating rating = context.Ratings.Single(x => x.RatingId == id);
            context.Ratings.Remove(rating);
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
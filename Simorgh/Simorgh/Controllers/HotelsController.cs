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
    public class HotelsController : Controller
    {
        private SimorghContext context = new SimorghContext();

        //
        // GET: /Hotels/

        public ViewResult Index()
        {
            return View(context.Hotels.Include(hotel => hotel.City).Include(hotel => hotel.ImageFile).Include(hotel => hotel.RoomType).Include(hotel => hotel.Rating).ToList());
        }

        //
        // GET: /Hotels/Details/5

        public ViewResult Details(int id)
        {
            Hotel hotel = context.Hotels.Single(x => x.HotelId == id);
            return View(hotel);
        }

        //
        // GET: /Hotels/Create

        public ActionResult Create()
        {
            ViewBag.PossibleCities = context.Cities;
            return View();
        } 

        //
        // POST: /Hotels/Create

        [HttpPost]
        public ActionResult Create(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                context.Hotels.Add(hotel);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleCities = context.Cities;
            return View(hotel);
        }
        
        //
        // GET: /Hotels/Edit/5
 
        public ActionResult Edit(int id)
        {
            Hotel hotel = context.Hotels.Single(x => x.HotelId == id);
            ViewBag.PossibleCities = context.Cities;
            return View(hotel);
        }

        //
        // POST: /Hotels/Edit/5

        [HttpPost]
        public ActionResult Edit(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                context.Entry(hotel).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleCities = context.Cities;
            return View(hotel);
        }

        //
        // GET: /Hotels/Delete/5
 
        public ActionResult Delete(int id)
        {
            Hotel hotel = context.Hotels.Single(x => x.HotelId == id);
            return View(hotel);
        }

        //
        // POST: /Hotels/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Hotel hotel = context.Hotels.Single(x => x.HotelId == id);
            context.Hotels.Remove(hotel);
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
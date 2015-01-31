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
    public class RoomTypesController : Controller
    {
        private SimorghContext context = new SimorghContext();

        //
        // GET: /RoomTypes/

        public ViewResult Index()
        {
            return View(context.RoomTypes.Include(roomtype => roomtype.RoomTypeImageFiles).ToList());
        }

        //
        // GET: /RoomTypes/Details/5

        public ViewResult Details(int id)
        {
            RoomType roomtype = context.RoomTypes.Single(x => x.RoomTypeId == id);
            return View(roomtype);
        }

        //
        // GET: /RoomTypes/Create

        public ActionResult Create()
        {
            ViewBag.PossibleHotels = context.Hotels;
            return View();
        } 

        //
        // POST: /RoomTypes/Create

        [HttpPost]
        public ActionResult Create(RoomType roomtype)
        {
            if (ModelState.IsValid)
            {
                context.RoomTypes.Add(roomtype);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleHotels = context.Hotels;
            return View(roomtype);
        }
        
        //
        // GET: /RoomTypes/Edit/5
 
        public ActionResult Edit(int id)
        {
            RoomType roomtype = context.RoomTypes.Single(x => x.RoomTypeId == id);
            ViewBag.PossibleHotels = context.Hotels;
            return View(roomtype);
        }

        //
        // POST: /RoomTypes/Edit/5

        [HttpPost]
        public ActionResult Edit(RoomType roomtype)
        {
            if (ModelState.IsValid)
            {
                context.Entry(roomtype).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleHotels = context.Hotels;
            return View(roomtype);
        }

        //
        // GET: /RoomTypes/Delete/5
 
        public ActionResult Delete(int id)
        {
            RoomType roomtype = context.RoomTypes.Single(x => x.RoomTypeId == id);
            return View(roomtype);
        }

        //
        // POST: /RoomTypes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            RoomType roomtype = context.RoomTypes.Single(x => x.RoomTypeId == id);
            context.RoomTypes.Remove(roomtype);
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
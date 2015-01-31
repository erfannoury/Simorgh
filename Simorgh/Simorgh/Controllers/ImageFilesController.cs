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
    public class ImageFilesController : Controller
    {
        private SimorghContext context = new SimorghContext();

        //
        // GET: /ImageFiles/

        public ViewResult Index()
        {
            return View(context.ImageFiles.ToList());
        }

        //
        // GET: /ImageFiles/Details/5

        public ViewResult Details(int id)
        {
            ImageFile imagefile = context.ImageFiles.Single(x => x.ImageFileId == id);
            return View(imagefile);
        }

        //
        // GET: /ImageFiles/Create

        public ActionResult Create()
        {
            ViewBag.PossibleHotels = context.Hotels;
            ViewBag.PossibleRoomTypes = context.RoomTypes;
            return View();
        } 

        //
        // POST: /ImageFiles/Create

        [HttpPost]
        public ActionResult Create(ImageFile imagefile)
        {
            if (ModelState.IsValid)
            {
                context.ImageFiles.Add(imagefile);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleHotels = context.Hotels;
            ViewBag.PossibleRoomTypes = context.RoomTypes;
            return View(imagefile);
        }
        
        //
        // GET: /ImageFiles/Edit/5
 
        public ActionResult Edit(int id)
        {
            ImageFile imagefile = context.ImageFiles.Single(x => x.ImageFileId == id);
            ViewBag.PossibleHotels = context.Hotels;
            ViewBag.PossibleRoomTypes = context.RoomTypes;
            return View(imagefile);
        }

        //
        // POST: /ImageFiles/Edit/5

        [HttpPost]
        public ActionResult Edit(ImageFile imagefile)
        {
            if (ModelState.IsValid)
            {
                context.Entry(imagefile).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleHotels = context.Hotels;
            ViewBag.PossibleRoomTypes = context.RoomTypes;
            return View(imagefile);
        }

        //
        // GET: /ImageFiles/Delete/5
 
        public ActionResult Delete(int id)
        {
            ImageFile imagefile = context.ImageFiles.Single(x => x.ImageFileId == id);
            return View(imagefile);
        }

        //
        // POST: /ImageFiles/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ImageFile imagefile = context.ImageFiles.Single(x => x.ImageFileId == id);
            context.ImageFiles.Remove(imagefile);
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
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
    public class RoomReviewsController : Controller
    {
        private SimorghContext context = new SimorghContext();

        //
        // GET: /RoomReviews/

        public ViewResult Index()
        {
            return View(context.RoomReviews.Include(roomreview => roomreview.RoomType).ToList());
        }

        //
        // GET: /RoomReviews/Details/5

        public ViewResult Details(int id)
        {
            RoomReview roomreview = context.RoomReviews.Single(x => x.RoomReviewId == id);
            return View(roomreview);
        }

        //
        // GET: /RoomReviews/Create

        public ActionResult Create()
        {
            ViewBag.PossibleRoomTypes = context.RoomTypes;
            return View();
        } 

        //
        // POST: /RoomReviews/Create

        [HttpPost]
        public ActionResult Create(RoomReview roomreview)
        {
            if (ModelState.IsValid)
            {
                context.RoomReviews.Add(roomreview);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleRoomTypes = context.RoomTypes;
            return View(roomreview);
        }
        
        //
        // GET: /RoomReviews/Edit/5
 
        public ActionResult Edit(int id)
        {
            RoomReview roomreview = context.RoomReviews.Single(x => x.RoomReviewId == id);
            ViewBag.PossibleRoomTypes = context.RoomTypes;
            return View(roomreview);
        }

        //
        // POST: /RoomReviews/Edit/5

        [HttpPost]
        public ActionResult Edit(RoomReview roomreview)
        {
            if (ModelState.IsValid)
            {
                context.Entry(roomreview).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleRoomTypes = context.RoomTypes;
            return View(roomreview);
        }

        //
        // GET: /RoomReviews/Delete/5
 
        public ActionResult Delete(int id)
        {
            RoomReview roomreview = context.RoomReviews.Single(x => x.RoomReviewId == id);
            return View(roomreview);
        }

        //
        // POST: /RoomReviews/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            RoomReview roomreview = context.RoomReviews.Single(x => x.RoomReviewId == id);
            context.RoomReviews.Remove(roomreview);
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
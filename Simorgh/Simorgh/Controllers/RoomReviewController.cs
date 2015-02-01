//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using Simorgh.Models;

//namespace Simorgh.Controllers
//{
//    public class RoomReviewController : Controller
//    {
//        private RoomReviewDbContext db = new RoomReviewDbContext();

//        // GET: /RoomReview/
//        public ActionResult Index()
//        {
//            return View(db.RoomReviews.ToList());
//        }

//        // GET: /RoomReview/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            RoomReview roomreview = db.RoomReviews.Find(id);
//            if (roomreview == null)
//            {
//                return HttpNotFound();
//            }
//            return View(roomreview);
//        }

//        // GET: /RoomReview/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: /RoomReview/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include="RoomReviewId,TravellerUserId,RoomTypeId,ReviewDate,Review,RateUp,RateDown,IsConfirmed")] RoomReview roomreview)
//        {
//            if (ModelState.IsValid)
//            {
//                db.RoomReviews.Add(roomreview);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(roomreview);
//        }

//        // GET: /RoomReview/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            RoomReview roomreview = db.RoomReviews.Find(id);
//            if (roomreview == null)
//            {
//                return HttpNotFound();
//            }
//            return View(roomreview);
//        }

//        // POST: /RoomReview/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include="RoomReviewId,TravellerUserId,RoomTypeId,ReviewDate,Review,RateUp,RateDown,IsConfirmed")] RoomReview roomreview)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(roomreview).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(roomreview);
//        }

//        // GET: /RoomReview/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            RoomReview roomreview = db.RoomReviews.Find(id);
//            if (roomreview == null)
//            {
//                return HttpNotFound();
//            }
//            return View(roomreview);
//        }

//        // POST: /RoomReview/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            RoomReview roomreview = db.RoomReviews.Find(id);
//            db.RoomReviews.Remove(roomreview);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}

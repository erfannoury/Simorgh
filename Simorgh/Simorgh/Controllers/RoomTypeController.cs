using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Simorgh.Models;

namespace Simorgh.Controllers
{
    public class RoomTypeController : Controller
    {
        private RoomTypeDBContext db = new RoomTypeDBContext();

        // GET: /RoomType/
        [Authorize(Roles = "HotelOwner")]
        public ActionResult Index()
        {
            return View(db.RoomTypes.ToList());
        }

        // GET: /RoomType/Details/5
        [Authorize(Roles = "HotelOwner")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomType roomtype = db.RoomTypes.Find(id);
            if (roomtype == null)
            {
                return HttpNotFound();
            }
            return View(roomtype);
        }

        // GET: /RoomType/Create
        [Authorize(Roles = "HotelOwner")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: /RoomType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "HotelOwner")]
        public ActionResult Create([Bind(Include="RoomTypeId,HotelId,ImageFolderId,Title,Description,RoomCapacity,TotalCount,VacantCount,Price")] RoomType roomtype)
        {
            if (ModelState.IsValid)
            {
                db.RoomTypes.Add(roomtype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(roomtype);
        }

        // GET: /RoomType/Edit/5
        [Authorize(Roles = "HotelOwner")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomType roomtype = db.RoomTypes.Find(id);
            if (roomtype == null)
            {
                return HttpNotFound();
            }
            return View(roomtype);
        }

        // POST: /RoomType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "HotelOwner")]
        public ActionResult Edit([Bind(Include="RoomTypeId,HotelId,ImageFolderId,Title,Description,RoomCapacity,TotalCount,VacantCount,Price")] RoomType roomtype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roomtype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roomtype);
        }

        // GET: /RoomType/Delete/5
        [Authorize(Roles = "HotelOwner")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomType roomtype = db.RoomTypes.Find(id);
            if (roomtype == null)
            {
                return HttpNotFound();
            }
            return View(roomtype);
        }

        // POST: /RoomType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "HotelOwner")]
        public ActionResult DeleteConfirmed(int id)
        {
            RoomType roomtype = db.RoomTypes.Find(id);
            db.RoomTypes.Remove(roomtype);
            db.SaveChanges();
            return RedirectToAction("Index");
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

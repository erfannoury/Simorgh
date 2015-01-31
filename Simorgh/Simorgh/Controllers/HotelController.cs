using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Simorgh.Models;

namespace Simorgh.Controllers
{
    public class HotelController : Controller
    {
        private SimorghContext context = new SimorghContext();

        // GET: /Hotel/
        [Authorize(Roles = "Admin, HotelOwner")]
        public ActionResult Index()
        {
            return View(context.Hotels.Include(hotel => hotel.RoomTypes).Include(hotel => hotel.HotelImageFiles).ToList());
        }

        // GET: /Hotel/SearchResult/{name}
        [HttpGet]
        public ActionResult SearchResult(string cityName)
        {
            var hotels = from h in context.Hotels
                         select h;
            if (!String.IsNullOrEmpty(cityName))
            {
                int id;
                try
                {
                    id = context.Cities.Where(c => c.CityName.Contains(cityName)).FirstOrDefault().CityId;
                    if (id == null)
                        throw new Exception();
                }
                catch (Exception)
                {
                    ViewBag.HasResult = false;
                    ViewBag.ErrorMessage = "نتیجه ای یافت نشد.";
                    return View();
                }
                hotels = hotels.Where(h => h.CityId == id);
                ViewBag.HasResult = true;
                return View(hotels.ToList());
            }
            ViewBag.HasResult = false;
            ViewBag.ErrorMessage = "نتیجه ای یافت نشد.";
            return View();
        }

        // GET: /Hotel/Details/5
        [Authorize(Roles = "Admin, HotelOwner")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hotel hotel = context.Hotels.Find(id);
            if (hotel == null)
            {
                return HttpNotFound();
            }
            return View(hotel);
        }

        // GET: /Hotel/Create
        [Authorize(Roles = "Admin, HotelOwner")]
        public ActionResult Create()
        {
            ViewBag.PossibleCities = context.Cities;
            return View();
        }

        // POST: /Hotel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, HotelOwner")]
        public ActionResult Create([Bind(Include="Id,Name,Address,Longitude,Latitude,Description,Star")] Hotel hotel, string cityName)
        {
            if (ModelState.IsValid)
            {
                
                //foreach (var imgid in ImageIds.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                //{
                //    hotel.ImageIdList.Add(int.Parse(imgid));
                //}

                var city = context.Cities.Where(c => c.CityName == cityName).FirstOrDefault();

                if (city != null)
                {
                    hotel.CityId = city.CityId;
                    hotel.HotelCity = city;
                }
                else
                {
                    context.Cities.Add(new City() {CityName = cityName});
                    context.SaveChanges();
                    hotel.CityId = context.Cities.Where(c => c.CityName == cityName).First().CityId;
                }

                context.Hotels.Add(hotel);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleCities = context.Cities;
            return View(hotel);
        }

        // GET: /Hotel/Edit/5
        [Authorize(Roles = "Admin, HotelOwner")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hotel hotel = context.Hotels.Find(id);
            if (hotel == null)
            {
                return HttpNotFound();
            }
            return View(hotel);
        }

        // POST: /Hotel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "HotelOwner")]
        public ActionResult Edit([Bind(Include="Id,ImageFolderId,Name,CityId,Address,Longitude,Latitude,Description,Star")] Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                context.Entry(hotel).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hotel);
        }

        // GET: /Hotel/Delete/5
        [Authorize(Roles = "HotelOwner")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hotel hotel = context.Hotels.Find(id);
            if (hotel == null)
            {
                return HttpNotFound();
            }
            return View(hotel);
        }

        // POST: /Hotel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hotel hotel = context.Hotels.Find(id);
            context.Hotels.Remove(hotel);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

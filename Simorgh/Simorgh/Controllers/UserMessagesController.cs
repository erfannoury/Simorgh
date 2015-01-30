using Simorgh.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Simorgh.Controllers
{
    public class UserMessagesController : Controller
    {
        private MessageDbContext db = new MessageDbContext();

        //
        // GET: /UserMessages/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inbox()
        {
            String username = User.Identity.Name;
            var entries = from u in db.UserMessages where ((u.ToUserName == username)) select u;
            return View(entries.ToList());
        }

        public ActionResult Sent()
        {
            String username = User.Identity.Name;
            var entries = from u in db.UserMessages where (u.FromUserName == username) select u;
            return View(entries.ToList());
        }

        // GET: /Inbox/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserMessage usermessage = db.UserMessages.Find(id);

            if (usermessage == null)
            {
                return HttpNotFound();
            }

            usermessage.isRead = true;
            db.Entry(usermessage).State = EntityState.Modified;
            db.SaveChanges();

            return View(usermessage);
        }

        // GET: /Inbox/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Inbox/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FromUserName,ToUserName,ReplyToMessage,MessageText,MessageTime,isRead")] UserMessage usermessage)
        {
            if (ModelState.IsValid)
            {
                db.UserMessages.Add(usermessage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usermessage);
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
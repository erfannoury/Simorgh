﻿using Simorgh.Models;
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
        [Authorize(Roles = "User, Admin, HotelOwner")]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "User, Admin, HotelOwner")]
        public ActionResult Inbox()
        {
            String username = User.Identity.Name;
            Boolean isUserAdmin = User.IsInRole("Admin");
            var entries = from u in db.UserMessages 
                          where ((u.ToUserName == username ||
                          (u.ToUserName=="support" & isUserAdmin))
                          & (u.DeletedFromInbox == false) ) select u;
            entries = entries.OrderByDescending(u => u.MessageTime);
            return View(entries.ToList());
        }

        [Authorize(Roles = "User, Admin, HotelOwner")]
        public ActionResult Sent()
        {
            String username = User.Identity.Name;
            var entries = from u in db.UserMessages
                          where ((u.FromUserName == username) & (u.DeletedFromSent == false)) select u;
            entries = entries.OrderByDescending(u => u.MessageTime);
            return View(entries.ToList());
        }

        // GET: /Inbox/Details/5
        [Authorize(Roles = "User, Admin, HotelOwner")]
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

            var conversation = from u in db.UserMessages where ((u.Id == id) || (u.ReplyToMessage == usermessage.ReplyToMessage)
                                   || (u.Id == usermessage.ReplyToMessage) || (u.ReplyToMessage == usermessage.Id)) select u;

            foreach(var item in conversation)
            {
                item.isRead = true;
                db.Entry(item).State = EntityState.Modified;
            }
            db.SaveChanges();

            return View(conversation.ToList().OrderBy(u => u.MessageTime));
        }

        // GET: /Inbox/Create
        [Authorize(Roles = "User, Admin, HotelOwner")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Inbox/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "User, Admin, HotelOwner")]
        public ActionResult Create([Bind(Include = "Id,FromUserName,ToUserName,ReplyToMessage,MessageText,MessageTime,isRead")] UserMessage usermessage)
        {
            usermessage.FromUserName = User.Identity.Name;
            usermessage.MessageTime = System.DateTime.Now;
            if (!User.IsInRole("Admin"))
                usermessage.ToUserName = "support";

            Boolean error = false;
            
            if(usermessage.ReplyToMessage != 0)
            {
                UserMessage rep = db.UserMessages.Find(usermessage.ReplyToMessage);
                if (rep == null || 
                    ((rep.ToUserName != User.Identity.Name) && !(rep.ToUserName == "support" && User.IsInRole("Admin")))
                    || rep.FromUserName != usermessage.ToUserName)
                    error = true;
                else
                {
                    int source=0;
                    while (rep != null)
                    {
                        source = rep.Id;
                        rep = db.UserMessages.Find(rep.ReplyToMessage);
                    }
                    usermessage.ReplyToMessage = source;
                }

            }


            if (!error && ModelState.IsValid)
            {
                db.UserMessages.Add(usermessage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usermessage);
        }

        [Authorize(Roles = "User, Admin, HotelOwner")]
        public ActionResult DeleteFromInbox(int id)
        {
            UserMessage usermessage = db.UserMessages.Find(id);
            if(usermessage.DeletedFromSent)
                db.UserMessages.Remove(usermessage);
            else
            {
                usermessage.DeletedFromInbox = true;
                db.Entry(usermessage).State = EntityState.Modified;
                db.SaveChanges();
            }
            db.SaveChanges();
            return RedirectToAction("Inbox");
        }

        [Authorize(Roles = "User, Admin, HotelOwner")]
        public ActionResult DeleteFromSent(int id)
        {
            UserMessage usermessage = db.UserMessages.Find(id);
            if (usermessage.DeletedFromInbox)
                db.UserMessages.Remove(usermessage);
            else
            {
                usermessage.DeletedFromSent = true;
                db.Entry(usermessage).State = EntityState.Modified;
                db.SaveChanges();
            }
            db.SaveChanges();
            return RedirectToAction("Sent");
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
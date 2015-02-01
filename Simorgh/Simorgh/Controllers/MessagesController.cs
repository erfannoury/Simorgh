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
    public class MessagesController : Controller
    {
        private SimorghContext context = new SimorghContext();

        //
        // GET: /Messages/

        public ViewResult Index()
        {
            return View(context.Messages.ToList());
        }

        //
        // GET: /Messages/Details/5

        public ViewResult Details(string id)
        {
            Message message = context.Messages.Single(x => x.MessageId == id);
            return View(message);
        }

        //
        // GET: /Messages/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Messages/Create

        [HttpPost]
        public ActionResult Create(Message message)
        {
            if (ModelState.IsValid)
            {
                context.Messages.Add(message);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(message);
        }
        
        //
        // GET: /Messages/Edit/5
 
        public ActionResult Edit(string id)
        {
            Message message = context.Messages.Single(x => x.MessageId == id);
            return View(message);
        }

        //
        // POST: /Messages/Edit/5

        [HttpPost]
        public ActionResult Edit(Message message)
        {
            if (ModelState.IsValid)
            {
                context.Entry(message).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(message);
        }

        //
        // GET: /Messages/Delete/5
 
        public ActionResult Delete(string id)
        {
            Message message = context.Messages.Single(x => x.MessageId == id);
            return View(message);
        }

        //
        // POST: /Messages/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            Message message = context.Messages.Single(x => x.MessageId == id);
            context.Messages.Remove(message);
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
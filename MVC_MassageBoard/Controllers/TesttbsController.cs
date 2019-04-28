using System;

using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_MassageBoard.Models;

namespace MVC_MassageBoard.Controllers
{
    public class TesttbsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Testtbs
        public ActionResult Index(string searchString)
        {
            var msg = from m in db.Testtables select m;
            if(!String.IsNullOrEmpty(searchString))
            {
                msg = msg.Where(s => (s.title.Contains(searchString))? (s.title.Contains(searchString)):((s.commet.Contains(searchString))? (s.commet.Contains(searchString)):(s.user.Contains(searchString))));
            }
            return View(msg);
        }

        // GET: Testtbs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Testtb testtb = db.Testtables.Find(id);
            if (testtb == null)
            {
                return HttpNotFound();
            }
            return View(testtb);
        }

        // GET: Testtbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Testtbs/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "user,title,commet,date")] Testtb testtb)
        {
            if (ModelState.IsValid)
            {
                db.Testtables.Add(testtb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testtb);
        }

        // GET: Testtbs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Testtb testtb = db.Testtables.Find(id);
            if (testtb == null)
            {
                return HttpNotFound();
            }
            return View(testtb);
        }

        // POST: Testtbs/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "user,title,commet,date")] Testtb testtb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testtb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testtb);
        }

        // GET: Testtbs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Testtb testtb = db.Testtables.Find(id);
            if (testtb == null)
            {
                return HttpNotFound();
            }
            return View(testtb);
        }

        // POST: Testtbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Testtb testtb = db.Testtables.Find(id);
            db.Testtables.Remove(testtb);
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

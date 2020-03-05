using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GamesReview.Models;

namespace GamesReview.Controllers
{
    public class GamesReviewsController : Controller
    {
        private ProductContext db = new ProductContext();

        // GET: GamesReviews
        public ActionResult Index()
        {
            return View(db.GamesReviews.ToList());
        }

        // GET: GamesReviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GamesReviews gamesReviews = db.GamesReviews.Find(id);
            if (gamesReviews == null)
            {
                return HttpNotFound();
            }
            return View(gamesReviews);
        }

        // GET: GamesReviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GamesReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GamesReviewsId,Comments,Ranking")] GamesReviews gamesReviews)
        {
            if (ModelState.IsValid)
            {
                db.GamesReviews.Add(gamesReviews);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gamesReviews);
        }

        // GET: GamesReviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GamesReviews gamesReviews = db.GamesReviews.Find(id);
            if (gamesReviews == null)
            {
                return HttpNotFound();
            }
            return View(gamesReviews);
        }

        // POST: GamesReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GamesReviewsId,Comments,Ranking")] GamesReviews gamesReviews)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gamesReviews).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gamesReviews);
        }

        // GET: GamesReviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GamesReviews gamesReviews = db.GamesReviews.Find(id);
            if (gamesReviews == null)
            {
                return HttpNotFound();
            }
            return View(gamesReviews);
        }

        // POST: GamesReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GamesReviews gamesReviews = db.GamesReviews.Find(id);
            db.GamesReviews.Remove(gamesReviews);
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

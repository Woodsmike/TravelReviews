using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelReviews.Models;

namespace TravelReviews.Controllers
{
    public class ReviewerLevelsController : Controller
    {
        private TravelReviewsContext db = new TravelReviewsContext();

        // GET: ReviewerLevels
        public ActionResult Index()
        {
            return View(db.ReviewerLevels.ToList());
        }

        // GET: ReviewerLevels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewerLevel reviewerLevel = db.ReviewerLevels.Find(id);
            if (reviewerLevel == null)
            {
                return HttpNotFound();
            }
            return View(reviewerLevel);
        }

        // GET: ReviewerLevels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReviewerLevels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReviewerLevelID,Level")] ReviewerLevel reviewerLevel)
        {
            if (ModelState.IsValid)
            {
                db.ReviewerLevels.Add(reviewerLevel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reviewerLevel);
        }

        // GET: ReviewerLevels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewerLevel reviewerLevel = db.ReviewerLevels.Find(id);
            if (reviewerLevel == null)
            {
                return HttpNotFound();
            }
            return View(reviewerLevel);
        }

        // POST: ReviewerLevels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReviewerLevelID,Level")] ReviewerLevel reviewerLevel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reviewerLevel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reviewerLevel);
        }

        // GET: ReviewerLevels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewerLevel reviewerLevel = db.ReviewerLevels.Find(id);
            if (reviewerLevel == null)
            {
                return HttpNotFound();
            }
            return View(reviewerLevel);
        }

        // POST: ReviewerLevels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReviewerLevel reviewerLevel = db.ReviewerLevels.Find(id);
            db.ReviewerLevels.Remove(reviewerLevel);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LeagueExpress.Models;

namespace LeagueExpress.Controllers
{
    public class MatchSchedulesController : Controller
    {
        private LeagueExpressDB db = new LeagueExpressDB();

        // GET: MatchSchedules
        public ActionResult Index()
        {
            return View(db.MatchSchedules.ToList());
        }

        // GET: MatchSchedules/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchSchedule matchSchedule = db.MatchSchedules.Find(id);
            if (matchSchedule == null)
            {
                return HttpNotFound();
            }
            return View(matchSchedule);
        }

        // GET: MatchSchedules/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: MatchSchedules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,matchWeek,matchDate,matchTime,matchHomeTeam,matchAwayTeam,matchHomeResult,matchAwayResult,matchStatus")] MatchSchedule matchSchedule)
        {
            if (ModelState.IsValid)
            {
                db.MatchSchedules.Add(matchSchedule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(matchSchedule);
        }

        // GET: MatchSchedules/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchSchedule matchSchedule = db.MatchSchedules.Find(id);
            if (matchSchedule == null)
            {
                return HttpNotFound();
            }
            return View(matchSchedule);
        }

        // POST: MatchSchedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,matchWeek,matchDate,matchTime,matchHomeTeam,matchAwayTeam,matchHomeResult,matchAwayResult,matchStatus")] MatchSchedule matchSchedule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(matchSchedule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(matchSchedule);
        }


        // GET: MatchSchedules/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchSchedule matchSchedule = db.MatchSchedules.Find(id);
            if (matchSchedule == null)
            {
                return HttpNotFound();
            }
            return View(matchSchedule);
        }


        // POST: MatchSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MatchSchedule matchSchedule = db.MatchSchedules.Find(id);
            db.MatchSchedules.Remove(matchSchedule);
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

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LeagueExpress.Models;
using LeagueExpress.Services;
using System.Text;

namespace LeagueExpress.Controllers
{
    public class PlayersController : Controller
    {
        private LeagueExpressDB db = new LeagueExpressDB();

        // GET: Players
        public ActionResult Index()
        {
            return View(db.Players.ToList());
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Manage()
        {
            return View(db.Players.ToList());
        }

        // GET: Players/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        
        // GET: Players/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Player player)
        {
            if (ModelState.IsValid)
            {

                db.Players.Add(player);
                db.SaveChanges();


                StringBuilder StrRegisterBody = new StringBuilder();
                StrRegisterBody.Append("Registration Created for: " + player.playerFirstName + "," + player.playerLastName);
                StrRegisterBody.AppendLine();
                StrRegisterBody.Append("Email: " + player.playerEmail);
                StrRegisterBody.AppendLine();
                StrRegisterBody.Append("Phone: " + player.playerPhoneNumber);
                StrRegisterBody.AppendLine();
                StrRegisterBody.Append("Player Age: " + player.playerAge);
                StrRegisterBody.AppendLine();
                StrRegisterBody.Append("Team of Preference: " + player.currentTeam);
                StrRegisterBody.AppendLine();
                StrRegisterBody.Append("Position Preferred: " + player.playerPosition);
                StrRegisterBody.AppendLine();
                StrRegisterBody.Append("Shirt Size: " + player.playerShirtSize);




                MailService message = new MailService();
                message.EmailFrom = "register@browardpremiereleague.com";
                message.EmailTo = System.Configuration.ConfigurationManager.AppSettings["RegistrationEmail"].ToString();
                message.Subject = "Registration Created";
                message.Body = StrRegisterBody.ToString();
                message.SendEmail();

                return RedirectToAction("Pay");
            }

            return View(player);
        }

        // GET: Players/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        public ActionResult Payed()
        {
            return View();
        }

        public ActionResult Pay()
        {
            return View();
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PlayerViewModel player)
        {
            if (ModelState.IsValid)

            {
                var dbPlayer = db.Players.Find(player.Id);

                dbPlayer.hasPayed = player.hasPayed;
                dbPlayer.currentTeam = player.currentTeam;
                dbPlayer.playerStatus = player.playerStatus;
                dbPlayer.isCaptain = player.isCaptain;
                dbPlayer.playerPosition = player.playerPosition;
                dbPlayer.Gender = player.Gender;

                db.Entry(dbPlayer).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(player);
        }



        // GET: Players/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
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

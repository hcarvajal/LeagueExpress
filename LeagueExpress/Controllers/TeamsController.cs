using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeagueExpress.Services;
using LeagueExpress.Models;

namespace LeagueExpress.Controllers
{
    public class TeamsController : Controller
    {
        LeagueExpressDB _db = new LeagueExpressDB();

        // GET: Teams
        public ActionResult Index()
        {
            return View();
        }

        // load White page
        public ActionResult White(String Team)
        {
            Team = "White";
            var tPlayer = from p in _db.Players
                          where p.currentTeam.ToUpper().Contains(Team)
                          select p;

                          return View(tPlayer);
        }

        // load Purple page
        public ActionResult Purple(String Team)
        {
            Team = "Purple";
            var tPlayer = from p in _db.Players
                          where p.currentTeam.ToUpper().Contains(Team)
                          select p;

            return View(tPlayer);
        }

        // load Green page
        public ActionResult Green(String Team)
        {
            Team = "Green";
            var tPlayer = from p in _db.Players
                          where p.currentTeam.ToUpper().Contains(Team)
                          select p;

            return View(tPlayer);
        }

        // load Yellow page
        public ActionResult Yellow(String Team)
        {
            Team = "Yellow";
            var tPlayer = from p in _db.Players
                          where p.currentTeam.ToUpper().Contains(Team)
                          select p;

            return View(tPlayer);
        }

        // load Black page
        public ActionResult Black(String Team)
        {
            Team = "Black";
            var tPlayer = from p in _db.Players
                          where p.currentTeam.ToUpper().Contains(Team)
                          select p;

            return View(tPlayer);
        }

        // load Red page
        public ActionResult Red(String Team)
        {
            Team = "Red";
            var tPlayer = from p in _db.Players
                          where p.currentTeam.ToUpper().Contains(Team)
                          select p;

            return View(tPlayer);
        }

        // load Navy Blue page
        public ActionResult NavyBlue(String Team)
        {
            Team = "Navy Blue";
            var tPlayer = from p in _db.Players
                          where p.currentTeam.ToUpper().Contains(Team)
                          select p;

            return View(tPlayer);
        }

        // load Grey page
        public ActionResult Grey(String Team)
        {
            Team = "Grey";
            var tPlayer = from p in _db.Players
                          where p.currentTeam.ToUpper().Contains(Team)
                          select p;

            return View(tPlayer);
        }

        // load Light Blue page
        public ActionResult LightBlue(String Team)
        {
            Team = "Light Blue";
            var tPlayer = from p in _db.Players
                          where p.currentTeam.ToUpper().Contains(Team)
                          select p;

            return View(tPlayer);
        }

    }
}
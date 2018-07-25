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

        // load white page
        public ActionResult White(String Team)
        {
            Team = "White";
            var tPlayer = from p in _db.Players
                          where p.currentTeam.ToUpper().Contains(Team)
                          select p;

                          return View(tPlayer);
        }


       



       
          


    }
}
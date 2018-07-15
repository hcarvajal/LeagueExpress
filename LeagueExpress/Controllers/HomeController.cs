using LeagueExpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeagueExpress.Controllers
{
    public class HomeController : Controller
    {
        LeagueExpressDB _db = new LeagueExpressDB();
        public ActionResult Index()
        {
            return View();

            // check if user has a registration
      
            
        }

        public ActionResult About()
        {
            ViewBag.Mission = "Mission Statement";
            ViewBag.Philosophy = "Philosophy";
            ViewBag.Tournament = "Tournament:";
            ViewBag.GameTime = "Game time:";
            ViewBag.Cost = "Cost for participation:";
            ViewBag.Register = "To register, you need to:";
            ViewBag.TeamSelection = "Team Selection:";
            ViewBag.Teams = "Team names and active rosters:";
            ViewBag.Eligibility = "Eligibility of Participation:";
            ViewBag.Rules = "Rules standard during games:";
            ViewBag.Exceptions = "Player Conduct:";
            ViewBag.PlayerTime = "Playing Time/Length of Game:";
            ViewBag.PlayerReq = "Player Requirement:";
            ViewBag.PlayerUniform = "Player Uniform/Attire:";
            ViewBag.Provision = "Provisions for adding players:";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(Contact contact)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Contact");
            }

            return View();
        }


    }
}
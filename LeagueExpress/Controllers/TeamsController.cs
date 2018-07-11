using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeagueExpress.Services;

namespace LeagueExpress.Controllers
{
    public class TeamsController : Controller
    {
        // GET: Teams
        public ActionResult Index()
        {
            return View();
        }

        // load white page
        public ActionResult White()
        {
            return View();
        }

       
          


    }
}
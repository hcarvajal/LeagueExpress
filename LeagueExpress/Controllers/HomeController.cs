using LeagueExpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeagueExpress.Services;
using System.Text;

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


        public ActionResult News()
        {
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

                _db.Contacts.Add(contact); 
                _db.SaveChanges();

                StringBuilder StrRegisterBody = new StringBuilder();
                StrRegisterBody.Append("Name : " + contact.Name);
                StrRegisterBody.AppendLine();
                StrRegisterBody.Append("Email: " + contact.Email);
                StrRegisterBody.AppendLine();
                StrRegisterBody.Append("Reason: " + contact.Reason);
                StrRegisterBody.AppendLine();
                StrRegisterBody.Append("Message: " + contact.Message);
        




                MailService message = new MailService();
                message.EmailFrom = "contact@browardpremiereleague.com";
                message.EmailTo = System.Configuration.ConfigurationManager.AppSettings["ContactEmail"].ToString();
                message.Subject = "Registration Created";
                message.Body = StrRegisterBody.ToString();
                message.SendEmail();


                return RedirectToAction("Index");
            }

            return View();
        }




    }
}
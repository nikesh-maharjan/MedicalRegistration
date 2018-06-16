using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using MyMedicalRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMedicalRegistration.Controllers
{
    
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
      
        public ActionResult Index()
        {
            //    var userId = User.Identity.GetUserId();
            //    var patientId = db.Patients.Where(c => c.ApplicationUserId == userId).First().Id;
            //    ViewBag.PatientId = patientId;

            //    var manager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            //    var user = manager.FindById(userId);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
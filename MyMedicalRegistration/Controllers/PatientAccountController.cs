using MyMedicalRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMedicalRegistration.Controllers
{
    public class PatientAccountController : Controller
    {
        public ActionResult Details()
        {
            Patient newPatient = new Patient
            {
                AccountNumber = "00001",
                FirstName = "Nikesh",
                LastName = "Maharjan",
                //Address = "Bozeman Loop",
                //City = "Fayetteville",
                //State = "NC",
                //ZIP = "28303",
                Balance = -500
            };
            return View(newPatient);
        }
        // GET: PatientAccount
        public ActionResult Index()
        {
            return View();
        }
    }
}
using MedicalRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalRegistration.Registration
{
    public class PatientRegistration
    {
        private IApplicationDbContext db;

        public PatientRegistration(IApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreatePatient(string firstName, string lastName, string address, string city,
            string state, string zip)
        {
            var IdNumber = (db.Patients.Count()).ToString.PadLeft(10, '0');
            var Patient = new Patient { FirstName = FirstName, Las }
        }
    }
}
using MyMedicalRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMedicalRegistration.Services
{
    public class PatientAccountService
    {
        private IApplicationDbContext db;

        public PatientAccountService(IApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreatePatient(string firstName, string lastName, string userId, decimal initialBalance)
        {
            var accountNumber = (0 + db.Patients.Count()).ToString().PadLeft(5, '0');
            var patient = new Patient { FirstName = firstName, LastName = lastName, AccountNumber = accountNumber, Balance = initialBalance, ApplicationUserId = userId };
            db.Patients.Add(patient);
            db.SaveChanges();
        }
    }
}
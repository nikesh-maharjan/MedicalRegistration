using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalRegistration.Models
{
    public class AccountVIewModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
    }
}
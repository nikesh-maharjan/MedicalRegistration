using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalRegistration.Models
{
    public class Patient
    {
        public string FirstName{get; set;}
        public string LastName { get; set; }
        public string Name { get { return String.Format("{0} {1}", this.FirstName, this.LastName); } }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public string ServiceId { get; set; }

    }
}
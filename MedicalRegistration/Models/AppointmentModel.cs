using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalRegistration.Models
{
    public class AppointmentModel
    {
        public string AppointmentId { get; set; }
        public string AppointmentTime { get; set; }
        public string AppointmentReason { get; set; }
    }
}
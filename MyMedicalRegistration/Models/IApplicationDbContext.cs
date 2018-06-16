using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyMedicalRegistration.Models
{
    public interface IApplicationDbContext
    {
        IDbSet<Patient> Patients { get; set; }

        int SaveChanges();
    }
}
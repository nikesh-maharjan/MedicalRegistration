using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalRegistration.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Account #")]
        [RegularExpression(@"\d{5,10}", ErrorMessage = "Account # must be between 5 and 10 digits.")]
        //[StringLength(10,MinimumLength =5)]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName{get; set;}

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
       
        public string Name { get { return String.Format("{0} {1}", this.FirstName, this.LastName); } }

        [Required]
        public string Address { get; set; }
        
        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string ZIP { get; set; }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
        public string ApplicationUserId { get; set; }
    }
}
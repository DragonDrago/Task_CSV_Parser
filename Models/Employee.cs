using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Csv_Importer.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Payroll number")]
        public string PayrollNumber { get; set; }

        [Display(Name = "Forenames")]
        public string Forenames { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Telephone")]
        public string Telephone { get; set; }

        [Display(Name = "Mobile")]
        public string Mobile { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Address 2")]
        public string Address2 { get; set; }

        [Display(Name = "Postcode")]
        public string Postcode { get; set; }

        [Display(Name = "Email home")]
        public string EmailHome { get; set; }

        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }
    }
}

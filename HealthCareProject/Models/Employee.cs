using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthCareProject.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        public int SapId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public int? Age { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
    }
}
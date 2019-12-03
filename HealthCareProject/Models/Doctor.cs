using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthCareProject.Models
{
    public class Doctor
    {
        [Required]
        public int DoctorId { get; set; }
        public int DoctorSapId { get; set; }
        public string DoctorName { get; set; }
        public string Qualification { get; set; }
        public string EmailId { get; set; }

        [DataType(DataType.Time)]
        public DateTime Start_Time { get; set; }

        [DataType(DataType.Time)]
        public DateTime End_Time { get; set; }

        public bool IsAvailable { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Experience { get; set; }
        public string Gender { get; set; }
        public string ShiftDetails { get; set; }
        public string City { get; set; }
        public string Specialization { get; set; }
        public string Country { get; set; }
        public string Languages { get; set; }
       
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthCareProject.Models
{
    public class Appointments
    {
        [Required]
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime SlotTime { get; set; }
        public bool AppointmentStatus { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorSapId { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeSapId { get; set; }
    }
}
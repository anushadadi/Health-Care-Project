using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthCareProject.ViewModel
{
    public class DoctorPatientViewModel
    {
        public int Id { get; set; }

        public string PatientName { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string MobileNumber { get; set; }

        public string DoctorName { get; set; }

        public string Specialization { get; set; }

        public string Experience { get; set; }

        public string ShiftDetails { get; set; }

        public string Qualification { get; set; }

        public string Languages { get; set; }

        [DataType(DataType.Time)]

        public DateTime StartTime { get; set; }

        [DataType(DataType.Time)]

        public DateTime EndTime { get; set; }
    }
}
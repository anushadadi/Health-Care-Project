using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthCareProject.Models
{
    public class Login
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Email/SAP ID")]

        public string UserId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
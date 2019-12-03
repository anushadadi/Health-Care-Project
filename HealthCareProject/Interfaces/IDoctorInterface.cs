using HealthCareProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCareProject.Interfaces
{
    public interface IDoctorInterface
    {
        List<Doctor> SearchByLocation(string City, string specialisation);
    }
}
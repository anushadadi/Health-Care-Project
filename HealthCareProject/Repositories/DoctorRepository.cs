using HealthCareProject.Interfaces;
using HealthCareProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCareProject.Repositories
{
    public class DoctorRepository : IDoctorInterface
    {
        private ApplicationDbContext dbContext = null;
        public DoctorRepository()
        {
            dbContext = new ApplicationDbContext();
        }

        // GET: DoctorRepository
        public List<Doctor> SearchByLocation(string City, string Specialisation)
        {
            var doctor = from r in dbContext.Doctors orderby r.DoctorName where (r.City == City && r.Specialization == Specialisation) select r;
            return doctor.ToList();
        }
        public Doctor SearchById(int id)
        {
            var doctor = dbContext.Doctors.SingleOrDefault(c => c.DoctorId == id);
            return doctor;
        }
    }
}
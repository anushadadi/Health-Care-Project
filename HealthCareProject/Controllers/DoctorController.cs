using HealthCareProject.Interfaces;
using HealthCareProject.Models;
using HealthCareProject.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HealthCareProject.Controllers
{
    public class DoctorController : Controller
    {

        // GET: Doctor
        IDoctorInterface repository = new DoctorRepository();
        //public DoctorController(IDoctorInterface repository)
        //{
        //    this.repository = repository;
        //}
        private ApplicationDbContext DbContext = new ApplicationDbContext();
        public DoctorController() {}

        [HttpGet]
        public ActionResult Search()
        {
            ViewBag.City = SelectCity();
            ViewBag.Specialization = SearchDoctorSpecialization();
            return View();
        }
        [HttpPost]
        public ActionResult SearchView(Doctor doctor)
        {
            List<Doctor> doctorsList = repository.SearchByLocation(doctor.City, doctor.Specialization);
            if (doctorsList.Count != 0)
            {
                return View(doctorsList);
            }
            else
            {
                return Content("No Results Found");
            }
        }
       

        [NonAction]
        public IEnumerable<SelectListItem> SelectCity()
        {
            var City = (from m in DbContext.Doctors.AsEnumerable().GroupBy(m => m.City)
                        select new SelectListItem
                        {
                            Text = m.Key,
                            Value = m.Key
                        }).ToList();
            City.Insert(0, new SelectListItem { Text = "--Select Healthcare Centre--", Value = "0", Selected = true, Disabled = true });
            return City;

        }
        [NonAction]
        public IEnumerable<SelectListItem> SearchDoctorSpecialization()
        {
            var Specialization = (from m in DbContext.Doctors.AsEnumerable().GroupBy(m => m.Specialization)
                                  select new SelectListItem
                                  {
                                      Text = m.Key,
                                      Value = m.Key
                                  }).ToList();
            Specialization.Insert(0, new SelectListItem { Text = "--Select Doctor Specialization--", Value = "0", Selected = true, Disabled = true });
            return Specialization;

        }
    }
}



//[HttpPost]
//public async Task<ActionResult> SearchView(Doctor doctor1)
//{
//    List<Doctor> doctor = null;
//    var City = doctor1.City; var SearchDoctor = doctor1.Specialization;
//    using (var client = new HttpClient())
//    {
//        client.BaseAddress = new Uri(ApiBaseAddress);
//        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/Json"));
//        var result = await client.GetAsync($"DoctorApi/{City}/{SearchDoctor}");
//        if (result.StatusCode == System.Net.HttpStatusCode.NotFound)
//        {
//            return HttpNotFound("Doctor Not Found");
//        }
//        if (result.StatusCode == System.Net.HttpStatusCode.OK)
//        {
//            doctor = await result.Content.ReadAsAsync<List<Doctor>>();
//        }
//        else
//        {
//            doctor = null;
//        }
//        return View(doctor);

//    }
//}
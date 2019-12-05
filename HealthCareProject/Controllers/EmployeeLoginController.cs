using HealthCareProject.Models;
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
    public class EmployeeLoginController : Controller
    {
        // GET: EmployeeLogin
        private ApplicationDbContext dbContext = null;
        private string ApiBaseAddress = ConfigurationManager.AppSettings["ApiBaseAddress"];
        public EmployeeLoginController()
        {
            dbContext = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dbContext.Dispose();
            }

        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login employeeLogin)
        {

            var LoginInDb = dbContext.Employees.SingleOrDefault(c => (c.EmailId == employeeLogin.UserId) || (c.SapId.ToString() == employeeLogin.UserId));
            TempData["Id"] = LoginInDb.Id;
            if (LoginInDb != null)
            {
                if (LoginInDb.Password == employeeLogin.Password)
                {
                    var Login = new Login();
                    Login.UserId = employeeLogin.UserId;
                    Login.Password = employeeLogin.Password;
                    dbContext.Logins.Add(employeeLogin);
                    dbContext.SaveChanges();
                    return RedirectToAction("Search","Doctor");
                }
                else
                {
                    return Content("Login Failed");
                }
            }
            else
                return HttpNotFound("Enter Valid Details");

        }
        
    
}
}

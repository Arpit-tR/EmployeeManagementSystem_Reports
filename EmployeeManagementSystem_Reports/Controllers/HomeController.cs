using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagementSystem_Reports.Models;


namespace EmployeeManagementSystem_Reports.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeDBEntities db = new EmployeeDBEntities();

            ViewBag.TotalEmployees = db.Employees.Count();
            ViewBag.TotalDepartments = db.Departments.Count();

            ViewBag.MaleEmployees = db.Employees
                                      .Count(e => e.Gender == "Male");

            ViewBag.FemaleEmployees = db.Employees
                                        .Count(e => e.Gender == "Female");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
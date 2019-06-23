using MVCAppDb.Data.BusinesLogic;
using MVCAppDb.Data.Models;
using MVCAppDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppDb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult ViewEmployees()
        {
            ViewBag.Message = "Employee List";
            var data = EmployeeProcessor.LoadEmployees();
            List<Employee> employees = new List<Employee>();

            foreach (var row in data)
            {
                employees.Add(new Employee
                {
                    EmployeeID = row.EmployeeID,
                    FirstName = row.Firstname,
                    LastName = row.Lastname,
                    Email=row.Email
                });
            }
            return View(employees);
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(Employee model)
        {
            if(ModelState.IsValid)
            {
                EmployeeProcessor.CreateEmployee(
                    model.EmployeeID, 
                    model.FirstName,
                    model.LastName,
                    model.Email,
                    model.Password);

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
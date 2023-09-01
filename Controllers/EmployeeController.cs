using Elev8WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Elev8WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(EmployeeInfo employeeInfo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Here you can perform the logic to save the employeeInfo data to your database
                    // For example, you can use your chosen database context (MSSQL, MySQL, PostgreSQL) to save the data.
                    using (MyDBContext context = new MyDBContext())
                    {
                        context.EmployeeInfo.Add(employeeInfo);
                        context.SaveChanges();
                    }

                    ViewBag.message = "Save was succesful";
                    return View("Index");
                   // return RedirectToAction("Index", "Employee");
                }
            }
            catch (Exception ex)
            {

               
            }

            // If the ModelState is not valid, return back to the form with validation errors
            return View("Index", employeeInfo);
        }


        [HttpGet]
        public IActionResult viewRecords()
        {
            try
            {
              
                    using (MyDBContext context = new MyDBContext())
                    {
                      var lstEmployees=  context.EmployeeInfo.ToList();

                      ViewBag.lstEmployees = lstEmployees;
                    }

                   
                    return View();
                    
               
            }
            catch (Exception ex)
            {


            }

            // If the ModelState is not valid, return back to the form with validation errors
            return View("Index");
        }
    }
}

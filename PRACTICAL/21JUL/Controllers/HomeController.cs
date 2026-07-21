using _21JUL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _21JUL.Controllers
{
    public class HomeController : Controller
    {
        //display form
        public IActionResult Register()
        {
            return View();
        }
        //handle form submission
        [HttpPost]
        public IActionResult Register(Student student)
        {
            if(ModelState.IsValid)
            {
                TempData["StudentName"] = student.Name;
                return RedirectToAction("Schedule");

            }return View(student);
        }
        //course schedule page

        public ActionResult Schedule()
        {
            List<Course> course = new List<Course>()
            {

                new Course { courseName="asp.net" , sem="sem 3",sessionTime="9.30 - 11.00am", days="Mon - Tue" },
                new Course { courseName="java" , sem="sem 3",sessionTime="9.30 - 11.00am", days="Tue - Wed" },
                new Course { courseName="html" , sem="sem 3",sessionTime="9.30 - 11.00am", days="Fri - Sat"}

            };
            return View(course);

        }


    }
}

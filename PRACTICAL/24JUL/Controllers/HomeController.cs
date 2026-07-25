using _24JUL.Models;
using Microsoft.AspNetCore.Mvc;

namespace _24JUL.Controllers
{
    public class HomeController : Controller
    {
        //GET :login
        public IActionResult Index()
        {
            return View();
        }

        //POST :login

        [HttpPost]
        public IActionResult Index(Student student)
        {
            if (student.Username == "admin" && student.Password == "123456")
            {
                HttpContext.Session.SetString("User", student.Username);
                return RedirectToAction("Dashboard");
            }

            ViewBag.Error = "Invalid Username or Password";
            return View(student);
        }
        //dashboard
        public ActionResult Dashboard()
        {
            var user = HttpContext.Session.GetString("User");
            if (string.IsNullOrEmpty(user))
            {
                return RedirectToAction("Index");
            }
            ViewBag.User = user;

            List<Student> students = new List<Student>()
            {
            new Student { Id = 1, Name = "Rahul", RollNo = 10 ,Branch="IT"},
            new Student {Id = 2, Name = "Priya", RollNo = 11,Branch="IT" },
            new Student { Id = 3, Name = "Amit", RollNo = 12 , Branch = "IT"},
            new Student { Id = 4, Name = "Neha", RollNo = 13,Branch = "IT" }
            };
            return View(students);
            
            

        }

        //logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }

}




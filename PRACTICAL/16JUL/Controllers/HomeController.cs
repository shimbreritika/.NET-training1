using _16JUL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Cache;

namespace _16JUL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> student = new List<Student>()
            {

                new Student{Id = 101,Name="Ritika",Age =20, Course="DOT NET FRAMEWORK",Fees=20000,Qualification="HSC",Gender='F'},
              
                new Student{Id = 102,Name="Yash",Age =24, Course="JAVA DEVELOPMENT", Fees=25000, Qualification="HSC",Gender='M'},
                new Student{Id = 103,Name="Mansi",Age =21, Course="PYTHON DEVELOPMENT",Fees=20000,Qualification="HSC",Gender='F'},
                new Student{Id = 104,Name="Nidhi",Age =20, Course="JAVA FRAMEWORK",Fees=28000,Qualification="HSC",Gender='F'}
                
            };

            return View(student);
        }

       
    }
}

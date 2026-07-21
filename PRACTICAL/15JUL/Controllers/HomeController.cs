//by default controller program
//Brain of MVC
//recives user request, process data, call model , choose view , sends response

using _15JUL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _15JUL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //is an action method - every url calls an action method
        {
            return View();  //returns a view to the browser 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

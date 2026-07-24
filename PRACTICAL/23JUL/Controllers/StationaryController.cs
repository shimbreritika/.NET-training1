using _23JUL.Models;
using Microsoft.AspNetCore.Mvc;

namespace _23JUL.Controllers
{
    public class StationaryController : Controller
    {
        public IActionResult Details()
        {
            //check the login
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("User")))
            {
                return RedirectToAction("Login", "Home");
            }

            List<Stationary> stattionary= new List<Stationary>()
            {
                new Stationary{ID=1002, Name="Pensil", Price =10, Stock =46 },
                new Stationary{ID=1003, Name="Notebook", Price =150,Stock=89},
                new Stationary{ID=1104, Name="Marker", Price =50, Stock=34},
                new Stationary{ID=1005, Name="Scale", Price =20,Stock=34 }
            };
            return View(stattionary);
        }
    }
}

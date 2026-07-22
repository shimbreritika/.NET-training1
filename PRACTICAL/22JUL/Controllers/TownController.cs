using _22JUL.Models;
using Microsoft.AspNetCore.Mvc;

namespace _22JUL.Controllers
{
    public class TownController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        //recieve form dta
        [HttpPost]
        public ActionResult Create(Stationary stationary)
        {
            if (ModelState.IsValid)
            {
                //normally save to data base
                return Content($"StationayItem : {stationary.Item}," + $" Price : {stationary.Price}," + $"Category : {stationary.Category}," + $"Stock : {stationary.Stock},");
            }
            return View(stationary);
        }
    }
}

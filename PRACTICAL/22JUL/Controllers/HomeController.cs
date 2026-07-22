using _22JUL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _22JUL.Controllers
{
    public class HomeController : Controller
    {
        //display form
        public IActionResult Index()
        {

            return View();
        }
        //recieve form dta
        [HttpPost]
        public ActionResult Index(Product product)
        {
            if(ModelState.IsValid)
            {
                //normally save to data base
                return Content($"Product : {product.Name}," + $" Price : {product.Price}," + $"Category : {product.Category}," + $"Stock : {product.Stock},");
            }
            return View(product);
        }
    }
}

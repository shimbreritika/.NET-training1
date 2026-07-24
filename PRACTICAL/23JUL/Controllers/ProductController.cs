using _23JUL.Models;
using Microsoft.AspNetCore.Mvc;

namespace _23JUL.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        { 
            //check the login
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("User")))
            {
                return RedirectToAction("Login", "Home");
            }

            List<Product> products = new List<Product>()
            {
                new Product{ID=1, Name="Laptop", Price =78000},
                new Product{ID=2, Name="Phone", Price =98000},
                new Product{ID=3, Name="Charger", Price =700},
                new Product{ID=4, Name="Earphone", Price =1200}
            };
            return View(products);
        }
    }
}

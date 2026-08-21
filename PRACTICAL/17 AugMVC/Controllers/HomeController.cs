using _17_AugMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace _17_AugMVC.Controllers
{
    public class HomeController : Controller
    {
      private readonly IHttpClientFactory _httpClientFactory;
        //safely make a async http get request & deserialize JSON data into list of ViewModel

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        //get : home/index
        public async Task<IActionResult> Index() {
            var client = _httpClientFactory.CreateClient("_17_AugRest");

            var token = HttpContext.Session.GetString("JwtToken");

            if (string.IsNullOrEmpty(token))
            {
                return RedirectToAction("Login", "Account");
            }

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            var products =
                await client.GetFromJsonAsync<List<ProductViewModel>>(
                    "api/Product");

            return View(products ?? new List<ProductViewModel>());
        }

        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        //post : home /create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductViewModel product) {

            if (!ModelState.IsValid) { 
                return View(product);
            }
            var client = _httpClientFactory.CreateClient("_17_AugRest");

            var response = await client.PostAsJsonAsync("api/Product", product);

            if (response.IsSuccessStatusCode) { 
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Unable to add Product.");

            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id) {
            var client = _httpClientFactory.CreateClient("_17_AugRest");

            var product = await client.GetFromJsonAsync<ProductViewModel>($"api/Product/{id}");

            if (product == null)
                return NotFound();

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductViewModel product)
        {
            if(id != product.Id)
                return BadRequest();

            if (!ModelState.IsValid)
            {
                return View(product);
            }
            var client = _httpClientFactory.CreateClient("_17_AugRest");

         var response= await client.PutAsJsonAsync<ProductViewModel>($"api/Product/{id}", product);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            var errorMessage = await response.Content.ReadAsStringAsync();

            ModelState.AddModelError("", $"API Error {response.StatusCode} - {errorMessage}");

            return View(product);

        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id) {

            var client = _httpClientFactory.CreateClient("_17_AugRest");

            var product = await client.GetFromJsonAsync<ProductViewModel>($"api/Product/{id}");

            if (product == null)
                return NotFound();

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var client = _httpClientFactory.CreateClient("_17_AugRest");

            var response = await client.DeleteAsync($"api/Product/{id}");

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            var errorMessage = await response.Content.ReadAsStringAsync();

            ModelState.AddModelError("", $"API Error {response.StatusCode} - {errorMessage}");

            return RedirectToAction("Index");

        }
        
        }
}

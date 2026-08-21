using _17_AugMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace _17_AugMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET: /Category/Index
        public async Task<IActionResult> Index()
        {
            var client =
                _httpClientFactory.CreateClient("_17_AugRest");

            var token =
                HttpContext.Session.GetString("JwtToken");

            if (string.IsNullOrEmpty(token))
            {
                return RedirectToAction("Login", "Account");
            }

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            var categories =
                await client.GetFromJsonAsync<List<CategoryViewModel>>(
                    "api/Category");

            return View(categories ?? new List<CategoryViewModel>());
        }


        // GET: /Category/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        // POST: /Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            CategoryViewModel category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            var client =
                _httpClientFactory.CreateClient("_17_AugRest");

            var token =
                HttpContext.Session.GetString("JwtToken");

            if (string.IsNullOrEmpty(token))
            {
                return RedirectToAction("Login", "Account");
            }

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            var response =
                await client.PostAsJsonAsync(
                    "api/Category",
                    category);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }

            var errorMessage =
                await response.Content.ReadAsStringAsync();

            ModelState.AddModelError(
                "",
                $"API Error: {response.StatusCode} - {errorMessage}");

            return View(category);
        }


 

    }
}


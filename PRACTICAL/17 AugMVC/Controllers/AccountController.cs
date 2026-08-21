using _17_AugMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace _17_AugMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AccountController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var client =
                _httpClientFactory.CreateClient("_17_AugRest");

            var response = await client.PostAsJsonAsync(
                "api/Auth/login",
                model);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();

                ModelState.AddModelError(
                    "",
                    $"Login failed: {error}");

                return View(model);
            }

            var result =
                await response.Content.ReadFromJsonAsync<LoginResponse>();

            if (result == null || string.IsNullOrEmpty(result.Token))
            {
                ModelState.AddModelError(
                    "",
                    "API did not return a JWT token.");

                return View(model);
            }

            // Store JWT in MVC Session
            HttpContext.Session.SetString(
                "JwtToken",
                result.Token);

            // Go to Home/Index
            return RedirectToAction("Index", "Home");
        }



        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("JwtToken");

            return RedirectToAction(nameof(Login));
        }
    }
}

using _17_AugRest.Models;
using _17_AugRest.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _17_AugRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService service;

        public CategoryController(ICategoryService service) {
            this.service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Customer")]
        public IActionResult GetAll() {
            return Ok(service.GetCategories());
        }

        [HttpGet("{id}")]
        [Authorize(Roles ="Admin")]
        public IActionResult GetCategory(int id)
        {
            var category = service.GetCategoryById(id);

            if (category == null)
                return NotFound("Category is not avaliable");

            return Ok(category);
        }

        [HttpPost]
        [Authorize(Roles ="Admin")]
        public IActionResult AddCategory(Category category) { 
            
            service.AddCategory(category);
            return Ok(category);
        }
    }
}

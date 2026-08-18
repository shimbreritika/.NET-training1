using _14AUG.Model;
using _14AUG.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace _14AUG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Customer")]
        public IActionResult GetAll()
        {
            var products = service.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        [Authorize(Roles ="Admin")]
        public IActionResult GetProduct(int id)
        {
            var prod = service.GetProductById(id);
            if (prod == null)
                return NotFound("No Product Found");
            return Ok(prod);
        }

        [HttpPost]
        [Authorize(Roles ="Admin")]
        public IActionResult AddProduct(Product product)
        {
            service.AddProduct(product);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public IActionResult UpdateProduct(Product product)
        {
            service.UpdateProduct(product);
            return Ok();
        }
    }
}

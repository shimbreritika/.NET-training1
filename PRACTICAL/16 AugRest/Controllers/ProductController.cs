using _17_AugRest.Models;
using _17_AugRest.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _17_AugRest.Controllers
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
        public IActionResult GetAll()
        {
            return Ok(service.GetProducts());
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = service.GetProductById(id);
            if (product == null)
                return NotFound("Product is not avaliable");

            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddP(Product product)
        {
            service.AddProduct(product);
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateP(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest("Product ID mismatch");
            }

            var existingProduct = service.GetProductById(id);

            if (existingProduct == null)
            {
                return NotFound("Product is not available");
            }

            service.UpdateProduct(product);

            return Ok("Product updated successfully");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteP(int id)
        {
            var product = service.GetProductById(id);

            if (product == null)
            {
                return NotFound("Product is not available");
            }

            service.DeleteProduct(id);

            return Ok("Product deleted successfully");
        }
    }
}

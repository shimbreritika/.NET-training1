using _5AUG.Model;
using _5AUG.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _5AUG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRespository service;

        public ProductController(IProductRespository service)
        {
            this.service = service;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok(service.GetAll());
        }

        [HttpGet("{id}")]

        public IActionResult GetProduct(int id)
        {
            var product = service.GetProduct(id);
            if (product == null)
                return NotFound("Product is not avilable");
            return Ok(product);
        }

        [HttpPost]

        public IActionResult AddProduct(Product product)
        {
            service.AddProduct(product);
            return Ok(product);
        }

        [HttpPut]

        public IActionResult UpdateProduct(Product product)
        {
            service.UpdateProduct(product);
            return Ok(product);
        }

        [HttpDelete]

        public IActionResult DeleteProduct(int id)
        {
            service?.DeleteProduct(id);
            return Ok("Product deleted successfully");
        }
    }
}

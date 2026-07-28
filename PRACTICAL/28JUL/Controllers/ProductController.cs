using _28JUL.Model;
using _28JUL.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService service;

    public ProductsController(IProductService service)
    {
        this.service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(service.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetProductById(int id)
    {
        var product = service.GetById(id);

        if (product == null)
            return NotFound();

        return Ok(product);
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        var created = service.AddProduct(product);
        return Ok(created);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Product product)
    {
        var updated = service.UpdateProduct(id, product);

        if (updated == null)
            return NotFound();

        return Ok(updated);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (!service.DeleteProduct(id))
            return NotFound();

        return NoContent();
    }
}
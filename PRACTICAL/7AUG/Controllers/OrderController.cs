using _7AUG.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _7AUG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class OrdersController : ControllerBase { private readonly IOrderService service; public OrdersController(IOrderService service) { this.service = service; } [HttpGet] public ActionResult Get() { return Ok(service.GetOrders()); } }
}

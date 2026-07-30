using _30JUL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _30JUL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetBatches()
        {
            var batches = new List<Batch>
            {
                new Batch{Id=1101 , BatchName="C#"},
                new Batch{Id=1102 , BatchName="ASP.NET"}
            };

            return Ok(batches);
        }
    }
}

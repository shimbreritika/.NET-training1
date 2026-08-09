using _3AUG.Model;
using _3AUG.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3AUG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchController : ControllerBase
    {
        private readonly IBatchService _service;

        public BatchController(IBatchService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var batch = _service.GetBatch(id);

            if (batch == null)
                return NotFound("Batch not found");

            return Ok(batch);
        }

        [HttpPost]
        public IActionResult Post(Batch batch)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _service.AddBatch(batch);

            return Ok(batch);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Batch batch)
        {
            if (id != batch.Id)
                return BadRequest("Id mismatch");

            _service.UpdateBatch(batch);

            return Ok("Batch Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteBatch(id);

            return Ok("Batch Deleted");
        }
    }
}

using _3AUG.Model;
using _3AUG.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _3AUG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
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
            var student = _service.GetStudent(id);

            if (student == null)
                return NotFound("Student not found");

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _service.AddStudent(student);

            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            if (id != student.Id)
                return BadRequest("Id mismatch");

            _service.UpdateStudent(student);

            return Ok("Student Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteStudent(id);

            return Ok("Student deleted");
        }
    }
}
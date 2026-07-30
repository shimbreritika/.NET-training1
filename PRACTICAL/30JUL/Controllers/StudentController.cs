using _30JUL.Model;
using _30JUL.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _30JUL.Controllers
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

        public IActionResult GetStudents()
        {
            return Ok(_service.GetStudents());
        }

        [HttpGet("{id}")]

        public IActionResult GetStudents(int id)
        {
            var students = _service.GetStudentById(id);
            if (students == null) 
            return NotFound("student does not exists");

            return Ok(students);
        }

        [HttpPost]

        public IActionResult AddStudent(Student student)
        {
            _service.AddStudent(student);
            return Ok(student);
        }

    }
}

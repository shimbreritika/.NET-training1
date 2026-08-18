using _12AUG.Model;
using _12AUG.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace _12AUG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService service;

        public StudentController(IStudentService service)
        {
            this.service = service;
        }

        //Get All - admin + student
        [HttpGet]
        [Authorize(Roles="Admin , Student" )]
        public IActionResult GetAll()
        {
            var student = service.GetStudent();
            return Ok(student);
        }

        //Get by id - admin + student
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Student")]
        public IActionResult GetStudent(int id)
        {
            var student = service.GetStudentById(id);
            if (student == null)
                return NotFound("Student not found");
            return Ok(student);
        }

        //Add new student - post - Admin
        [HttpPost]
        [Authorize(Roles ="Admin")]
        public IActionResult AddStudent(Student student)
        {
            var student1= service.AddStudent(student);

            return Ok(student1);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult UpdateStudent(int id, Student student)
        {
            var result = service.UpdateStudent(id,student);

            if (result == null)
                return NotFound("Student not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteStudent(int id)
        {
            var result = service.DeleteStudent(id);

            if (result == null)
                return NotFound("Student not found");

            return Ok(result);
        }
    }
}

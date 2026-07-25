using _25JUL.Models;
using Microsoft.AspNetCore.Mvc;

namespace _25JUL.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //private automatic model validation , error handling, json resopnse, http method
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new()
        {
            new Student
            {
                id = 1,
                Name = "Ritika",
                Age = 19,
                Department="IT"
            },

             new Student
            {
                id = 2,
                Name = "Priya",
                Age = 21,
                Department="CSE"
            },

              new Student
            {
                id = 3,
                Name = "Jay",
                Age = 23,
                Department="Mechanical"
            } };
        [HttpGet] //fetch all students
        public IActionResult GetStudents()
        {
            return Ok(students); //200
        }

        [HttpGet("{id}")] //fetch student based on ID
        public IActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.id == id);
            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpPost] // add new student in existing student list
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);
            return CreatedAtAction(nameof(GetStudent),
            new { id = student.id }, student);
        }

        [HttpPut("{id}")]

        public IActionResult UpdateStudent(int id, Student updateStudent)
        {
            var student = students.FirstOrDefault(S => S.id == id);
            if (student == null)
                return NotFound();

            student.Age = updateStudent.Age;
            return NoContent(); //204
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteStudent(int id)
        {


            var student = students.FirstOrDefault(S => S.id == id);
            if (student == null)
                return NotFound(); //204

            students.Remove(student);

            return NoContent(); //204

        }
    }
}

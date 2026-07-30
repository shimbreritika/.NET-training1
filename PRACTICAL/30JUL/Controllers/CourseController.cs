using _30JUL.Model;
using Microsoft.AspNetCore.Mvc;

namespace _30JUL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private static List<Course> courses = new List<Course>()
        {
            new Course { Id = 1201, CourseName = "JAVA", Credits = 9, Duration = 35 },
            new Course { Id = 1202, CourseName = "C#", Credits = 9, Duration = 35 },
            new Course { Id = 1203, CourseName = "Python", Credits = 9, Duration = 35 }
        };

        [HttpGet]
        public IActionResult GetCourse()
        {
            return Ok(courses);
        }

        [HttpGet("{id}")]

        public IActionResult GetCourseById(int id)
        {
            var course = courses.FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return NotFound("Course not found");
            }

            return Ok(course);
        }
        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            courses.Add(course);
            return Ok(course);
        }
    }
}

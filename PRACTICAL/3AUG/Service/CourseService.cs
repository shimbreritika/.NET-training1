using _3AUG.Model;
using _3AUG.Repository;

namespace _3AUG.Service
{
    public class CourseService : ICourseService
    {
        private static List<Course> courses = new List<Course>()
        {
            new Course{Id = 1,Name = ".NET Full Stack",Duration = "6 Months",Fees = 50000},

            new Course{ Id = 2,Name = "Java Full Stack",Duration = "6 Months",Fees = 45000 },

            new Course{ Id = 3,Name = "Python",Duration = "4 Months",Fees = 30000 }
        };
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void DeleteCourse(int id)
        {
            var existing = GetCourse(id);

            if (existing == null)
                throw new Exception("Course not found");

            courses.Remove(existing);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course? GetCourse(int id)
        {
            return courses.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateCourse(Course course)
        {
            var existing = GetCourse(course.Id);

            if (existing == null)
                throw new Exception("Student not found");

            existing.Duration = course.Duration;
        }
    }
}

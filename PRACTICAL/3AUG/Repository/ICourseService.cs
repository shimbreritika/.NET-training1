using _3AUG.Model;

namespace _3AUG.Repository
{
    public interface ICourseService
    {
        List<Course> GetAll();

        Course? GetCourse(int id);

        void AddCourse(Course course);

        void UpdateCourse(Course course);

        void DeleteCourse(int id);
    }
}

using _30JUL.Model;

namespace _30JUL.Service
{
    public interface IStudentService
    {
        List<Student> GetStudents();

        Student? GetStudentById(int id);

        void AddStudent(Student student);

        
    }
}

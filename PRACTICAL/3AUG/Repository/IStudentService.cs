using _3AUG.Model;

namespace _3AUG.Repository
{
    public interface IStudentService
    {
        List<Student> GetAll();

        Student? GetStudent(int id);

        void AddStudent(Student student);

        void UpdateStudent(Student student);

        void DeleteStudent(int id);
    }
}

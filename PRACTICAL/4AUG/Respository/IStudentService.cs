using _4AUG.Models;
using System.Xml.Schema;

namespace _4AUG.Respository
{
    public interface IStudentService
    {
        List<Student> GetAll();

        Student? GetStudent (int id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
       
    }
}

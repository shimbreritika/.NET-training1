using _3AUG.Model;
using _3AUG.Repository;

namespace _3AUG.Service
{
    public class StudentService : IStudentService
    {
        private static List<Student> students = new List<Student>()
        {
            new Student{Id =1,Name= "Ritika" ,Age=22 ,Course="DotNet" ,Email="ritika@gmail.com"},
             new Student{Id =2,Name= "Purva" ,Age=23 ,Course="DotNet" ,Email="purva@gmail.com"},
              new Student{Id =3,Name= "Radha" ,Age=22 ,Course="Java" ,Email="radha@gmail.com"},
        };
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DeleteStudent(int id)
        {
            var existing = GetStudent(id);

            if (existing == null)
                throw new Exception("Student not found");

            students.Remove(existing);
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetStudent(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateStudent(Student student)
        {
            var existing=GetStudent(student.Id);

            if (existing == null)
                throw new Exception("Student not found");

            existing.Age = student.Age;
        }
    }
}

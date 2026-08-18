using _12AUG.Data;
using _12AUG.Model;
using _12AUG.Repository;

namespace _12AUG.Service
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext context;

        public StudentService(AppDbContext context)
        {
            this.context = context;
        }
        public Student? AddStudent(Student student)
        {
           context.Students12.Add(student);
            context.SaveChanges();
            return student; 
        }

        public List<Student> GetStudent()
        {
            return context.Students12.ToList();
        }

        public Student? GetStudentById(int id)

        {
            return context.Students12.Find(id);
        }

        public Student? UpdateStudent(int id,Student student)
        {
            var existingStudent = context.Students12.Find(id);

            if (existingStudent == null)
            {
                return null;
            }
            existingStudent.Age = student.Age;
          
            context.SaveChanges();

            return existingStudent;
        }

        public Student? DeleteStudent(int id)
        {
            var student = context.Students12.Find(id);

            if (student == null)
            {
                return null;
            }

            context.Students12.Remove(student);
            context.SaveChanges();

            return student;
        }
    }
}

using _30JUL.Model;

namespace _30JUL.Service
{
    public class StudentService :IStudentService
    {
        private static List<Student> students = new List<Student>()
        {
            new Student{Id =1 , FirstName="Rahul" ,LastName="Gupta", Phone=165285, BatchId=1101},
            new Student{Id =2 , FirstName="Aakash" ,LastName="Shah", Phone=159837, BatchId=1101},
            new Student{Id =3 , FirstName="Manish" ,LastName="Kapoor", Phone=249845, BatchId=1101},
            new Student{Id =4 , FirstName="Gajanan" ,LastName="Deshmukh", Phone=475285, BatchId=1101},
        };

        public List<Student> GetStudents()
        {
            return students; 
        }

        public Student? GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

  

       
    }
}

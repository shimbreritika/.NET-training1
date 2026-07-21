using System.ComponentModel.DataAnnotations;

namespace _21JUL.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Student name is mandatory")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="Student name must be at least of 3 letters and max to 20 letters")]
        public string Name {  get; set; }

        [Required(ErrorMessage = "Student age is mandatory")]
        [Range(18,25,ErrorMessage ="Student age must be between 18 and 25")]
        public int Age {  get; set; }

        [Required(ErrorMessage = "Student mail is mandatory")]
        [EmailAddress(ErrorMessage ="Email is incorrect,Enter a valid email id")]
        public string Email {  get; set; }

        [Required(ErrorMessage = "Student enrolled course name is mandatory")]
        public  string Course {  get; set; }

    }
}

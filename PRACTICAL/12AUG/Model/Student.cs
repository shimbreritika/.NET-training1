using System.ComponentModel.DataAnnotations;

namespace _12AUG.Model
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [StringLength(30 ,ErrorMessage ="30 MAX letters are allowed")]
        public string Name { get; set; } =string.Empty;

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 25, ErrorMessage = "Age must be between 18 to 25")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Mail is required")]
        [StringLength(30, ErrorMessage = "30 MAX letters are allowed")]
        [EmailAddress(ErrorMessage ="Mail id is incorrect")]
        public string Mail {  get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage ="Phone number is incorrect")]
        public string PhoneNumber {  get; set; }=string.Empty;

        [Required(ErrorMessage = "Course is required")]
        [StringLength(30, ErrorMessage = "30 MAX letters are allowed")]
        public string Course {  get; set; }= string.Empty;
    }
}

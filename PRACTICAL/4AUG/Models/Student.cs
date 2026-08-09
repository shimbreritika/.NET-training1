using System.ComponentModel.DataAnnotations;

namespace _4AUG.Models
{
    public class Student
    {
        public int Id {  get; set; }

        [Required(ErrorMessage ="Name is required")]
        [StringLength(25, ErrorMessage ="name max length is 25 lettrs only", MinimumLength =2)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Age is required")]
        [Range(18 ,25 ,ErrorMessage ="Age must be 18 to 15 only")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Email is not correct")]
        public string Email {  get; set; }
    }
}

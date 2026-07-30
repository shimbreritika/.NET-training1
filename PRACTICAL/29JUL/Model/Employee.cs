using System.ComponentModel.DataAnnotations;

namespace _29JUL.Model
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [StringLength(30, MinimumLength =3 ,ErrorMessage ="name must contain at least 3 letters")]
        public string Name { get; set; }

        [Range(10000000, 9999999999, ErrorMessage = "Phone number must be 8 to 10 digits")]
        public long PhoneN { get; set; }

        [Required(ErrorMessage = "email is required")]
        [EmailAddress(ErrorMessage ="invalid email address")]

        public string Email {  get; set; }

        [Required(ErrorMessage = "DeptId is required")]
        public int DeptId {  get; set; }

    }
}

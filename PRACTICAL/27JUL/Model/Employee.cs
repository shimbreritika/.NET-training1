using Microsoft.AspNetCore.Antiforgery;
using System.ComponentModel.DataAnnotations;

namespace _27JUL.Model
{
    public class Employee
    {
        [Required(ErrorMessage ="Emp id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Emp name is required")]
        [StringLength(25, MinimumLength =3, ErrorMessage ="Name Must be atleast 3 letters")]
        public string Name { get; set; }
        public string LastNmae {  get; set; }

        [Required(ErrorMessage = "Emp dept is required")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Dept cannot be more than 25 letters")]
        public string Dept {  get; set; }

        [Required(ErrorMessage = "Emp phone number is required")]
        public long PhoneNum {  get; set; }

        public string Profile { get; set; }

        public string Location { get; set; }

    }
}

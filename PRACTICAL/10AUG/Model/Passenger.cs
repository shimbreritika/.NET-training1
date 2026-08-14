using System.ComponentModel.DataAnnotations;

namespace _10AUG.Model
{
    public class Passenger
    {
        public int Id { get; set;  }

        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage ="Number is not required")]
        public string Phone {  get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Email id is not correct")]
        public string Email {  get; set; }


    }
}

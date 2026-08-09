using System.ComponentModel.DataAnnotations;

namespace _3AUG.Model
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Course name is required")]
        [StringLength(40 ,ErrorMessage = "Course name must not be more than 40 letters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Course duration is required")]
        [Range(45 ,89)]
        public string Duration { get; set; }

        [Required(ErrorMessage ="Course fees are required")]
        public int Fees { get; set; }
    }
}

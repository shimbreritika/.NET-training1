using System.ComponentModel.DataAnnotations;

namespace _3AUG.Model
{
    public class Batch
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Batch name is required")]
        [StringLength(30 , ErrorMessage = "Batch name must not be more than 30 letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Batch course is required")]
        public string Course { get; set; }

        [Required(ErrorMessage = "Batch start date is required")]
        public string StartDate { get; set; }

        [Required(ErrorMessage = "Batch capacity is required")]
        public int Capacity { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace _10AUG.Model
{
    public class Bus
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="BusNumber is required")]
        [StringLength(50)]
        public string BusNumber {  get; set; }

        [Required(ErrorMessage = "Total state is required")]
        [Range(1,50)]
        public int TotalStates {  get; set; }

        [Required(ErrorMessage = "BusType is required")]
        public string BusType {  get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace _10AUG.Model
{
    public class State
    {
        public int Id {  get; set; }

        [Required(ErrorMessage = "State name is required")]
        [StringLength(50)]
        public string StateName { get; set; } = string.Empty;

    }
}

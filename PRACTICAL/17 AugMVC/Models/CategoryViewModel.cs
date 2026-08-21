using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace _17_AugMVC.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category name is mandatory")]
        [StringLength(50, ErrorMessage = "Category name can be max 50 letter")]
        public string Name { get; set; } = string.Empty;

        [JsonIgnore]
        public ICollection<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
    }
}

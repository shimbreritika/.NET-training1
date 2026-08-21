using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace _17_AugRest.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Category name is mandatory")]
        [StringLength(50, ErrorMessage ="Category name can be max 50 letter")]
        public string Name { get; set; } = string.Empty;

        [JsonIgnore]
        public ICollection<Product> Products { get; set; } = new List<Product>();


    }
}

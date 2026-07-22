using System.ComponentModel.DataAnnotations;

namespace _22JUL.Models
{
    public class Stationary
    {
        public int Id;

        [Required(ErrorMessage = "Name is mandatory")]
        public string Item { get; set; }

        [Required(ErrorMessage = "Price is mandatory")]
        [Range(10, 100000)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Category is mandatory")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Stock is mandatory")]
        public int Stock { get; set; }
    }
}

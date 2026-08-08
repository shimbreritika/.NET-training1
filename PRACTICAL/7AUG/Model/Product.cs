using System.ComponentModel.DataAnnotations;

namespace _7AUG.Model
{
    public class Product
    {
        // Primary key
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(15, 1000000)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stock is required")]
        [Range(0, 10000)]
        public int Stock { get; set; }

        // One Product can appear in many OrderItems
        public ICollection<OrderItem> OrderItems { get; set; }  = new List<OrderItem>();
    }
}

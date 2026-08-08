using System.ComponentModel.DataAnnotations;

namespace _7AUG.Model
{
    public class Order
    {
        // Primary key
        public int Id { get; set; }

        [Required(ErrorMessage = "Customer name is required")]
        public string CustomerName { get; set; }

        // Stores order creation date
        public DateTime OrderDate { get; set; } = DateTime.Now;

        // One Order can contain multiple OrderItems
        public ICollection<OrderItem> OrderItems { get; set; }
            = new List<OrderItem>();
    }
}
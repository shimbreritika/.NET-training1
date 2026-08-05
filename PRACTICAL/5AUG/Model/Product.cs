using System.ComponentModel.DataAnnotations;

namespace _5AUG.Model
{
    public class Product
    {
        public int Id { get; set; } //primary key

        [Required(ErrorMessage = "product name is mandatory")]
        [StringLength(50, ErrorMessage = "Max letter for product must be below 50", MinimumLength = 5)]
        public string PName { get; set; }

        [Required(ErrorMessage = "product price is mandatory")]
        [Range(5,1000000,ErrorMessage ="Price can be between 5 to 1000000")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "product quantity is mandatory")]
        [Range(1,1000, ErrorMessage ="Quantity cannot be below 1 and above 1000")]
        public int Quantity {  get; set; }

        
    }
}

using System.ComponentModel.DataAnnotations;

namespace _17_AugMVC.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; } //primary key

        [Required(ErrorMessage = "Prodcut name is mandatory")]
        [StringLength(60, ErrorMessage = "Product name can be max 60 letters")]
        public string PName { get; set; }

        [Required(ErrorMessage = "Prodcut price is mandatory")]
        [Range(15, 1000000, ErrorMessage = "Product price cannot be less than 15 & more than 1000000")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Prodcut quantity is mandatory")]
        [Range(1, 100, ErrorMessage = "Product Quantity cannot be less than 1 & more than 100")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Prodcut stock availiable is mandatory")]
        [StringLength(3, ErrorMessage = "Product stock can be max of 3 letters")]
        public string Avaliability { get; set; }

        // Relationship
        [Required(ErrorMessage = "Please select a category")]
        public int? CategoryId { get; set; }

        // Used when displaying Product
        public CategoryViewModel? Category { get; set; }
    }
}

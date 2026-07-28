using System.ComponentModel.DataAnnotations;

namespace _28JUL.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Product name is required")]
        [StringLength(100, MinimumLength =5, ErrorMessage ="product name must be between 5 and 100" )]
        public string Name { get; set; }


        [Required(ErrorMessage = "Product price is required")]
        [Range(10,100000, ErrorMessage ="product price must be between 10 to 100000")]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "Product quantity is required")]
        [Range(10, 100, ErrorMessage = "product quantity must be between 10 to 100")]
        public int Quantity {  get; set; }

    }
}

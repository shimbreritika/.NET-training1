using System.ComponentModel.DataAnnotations;

namespace _14AUG.DTO
{
    public class ProductDto
    {
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; } = string.Empty;

        [Range(0.01 , double.MaxValue)]
        public decimal Price { get; set; }

    }
}

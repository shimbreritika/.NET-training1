using System.ComponentModel.DataAnnotations;

namespace _29JUL.Model
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vehicle Name is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Vehicle Name must contain at least 3 letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vehicle Number is required")]
        [RegularExpression(@"^[A-Z]{2}[0-9]{2}[A-Z]{2}[0-9]{4}$",
            ErrorMessage = "Enter a valid Vehicle Number (e.g. MH12AB1234)")]
        public string VehicleNumber { get; set; }

        [Required(ErrorMessage = "Vehicle Type is required")]
        public string VehicleType { get; set; }

        [Required(ErrorMessage = "Company Name is required")]
        public string CompanyName { get; set; }

        [Range(1900, 2100, ErrorMessage = "Enter a valid Manufacturing Year")]
        public int ManufacturingYear { get; set; }
    }
}

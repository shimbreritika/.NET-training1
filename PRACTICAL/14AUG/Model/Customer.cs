using System.ComponentModel.DataAnnotations;

namespace _14AUG.Model
{
    public class Customer
    {
        public int Id { get; set;  }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }= string.Empty;
        public string Password {  get; set; }=string.Empty;
        public ICollection<CustomerProduct> CustomerProducts { get; set; } = new List<CustomerProduct>();


    }
}

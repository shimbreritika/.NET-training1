namespace _14AUG.Model
{
    public class CustomerProduct
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null;
        public int ProductId {  get; set; }
        public Product Product { get; set; } = null;
        public int Quantity {  get; set; }

       
    }
}

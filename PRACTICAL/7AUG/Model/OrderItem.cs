namespace _7AUG.Model
{
    public class OrderItem
    {
        // Primary key
        public int Id { get; set; }

        // Foreign key referencing Product table
        public int ProductId { get; set; }

        // Allows access to Product details
        public Product? Product { get; set; }

        // Foreign key referencing Order table
        public int OrderId { get; set; }

        // Allows access to Order details
        public Order? Order { get; set; }

        // Number of units ordered
        public int Quantity { get; set; }
    }
}

//one order ----one to many ----orderitem
//orderitem------many to one -------product

//orderitem ----many to one -----product
//one product can appear in many orderitems

//orderitems 

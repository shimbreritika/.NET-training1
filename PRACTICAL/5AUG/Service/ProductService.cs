using _5AUG.Data;
using _5AUG.Model;
using _5AUG.Respository;

namespace _5AUG.Service
{
    //business logic for implementing CRUD on product entity
    public class ProductService :IProductRespository
    {
        private readonly AppDbContext context;

        public ProductService(AppDbContext context)
        {
            this.context = context;
        }

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = context.Products.Find(id);
            if (product != null) 
                context.Products.Remove(product);
            context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Product? GetProduct(int id)
        {
            return context.Products.Find(id);
        }

        public void UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();

        }
    }
}

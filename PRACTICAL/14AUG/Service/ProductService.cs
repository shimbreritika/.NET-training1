using _14AUG.Data;
using _14AUG.Model;
using _14AUG.Repository;

namespace _14AUG.Service
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext context;

        //constructor
        public ProductService(AppDbContext context)
        {
            this.context = context;
        }
        public Product AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }

        public Product? GetProductById(int id)
        {
            return context.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public Product UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
            return product;
        }
    }
}

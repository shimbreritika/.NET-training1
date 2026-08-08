using _7AUG.Data;
using _7AUG.Model;
using _7AUG.Repository;

namespace _7AUG.Service
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext context;
        public ProductService(AppDbContext context) 
        {
            this.context = context;
        }
        public Product AddProduct(Product product)
        {
            context.Products.Add(product); 
            context.SaveChanges(); return product; } public Product? GetProductById(int id) { return context.Products.Find(id); } public List<Product> GetProducts() { return context.Products.ToList(); } }


    }


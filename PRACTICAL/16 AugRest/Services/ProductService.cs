using _17_AugRest.Data;
using _17_AugRest.Models;
using _17_AugRest.Repository;
using Microsoft.EntityFrameworkCore;

namespace _17_AugRest.Services
{
    public class ProductService : IProductService
    {

        private readonly AppDbContext context;
        public ProductService(AppDbContext context)
        {
            this.context = context;
        }
        public void AddProduct(Product product)
        {
            context.products.Add(product); //implementation of adding new Product with help of add
            context.SaveChanges(); //saving new added product in table 
        }
        public void DeleteProduct(int id)
        {
            var product = context.products.Find(id);
            if (product != null) //check product avaliable
                context.products.Remove(product); //implementation of remove exisitng product from table
            context.SaveChanges(); // saving change in product detail of product table 
        }

        public Product? GetProductById(int id)
        {
            //  return context.products.Find(id); //implementation of getProduct By ID with help of find
            return context.products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetProducts()
        {
            // return context.products.ToList(); //implementation of getProduct with help of toList
            return context.products.Include(p => p.Category).ToList();
        }

        public void UpdateProduct(Product product)
        {
            //  context.products.Update(product); //implementation of updating existing Product with help of update
            // context.SaveChanges(); //saving existing updated product in table 

            var existingProduct = context.products.Find(product.Id);

            if (existingProduct == null)
                return;


            existingProduct.Price = product.Price;
            existingProduct.Quantity = product.Quantity;
            existingProduct.Avaliability = product.Avaliability;

            existingProduct.CategoryId = product.CategoryId;

            context.SaveChanges();
        }
    }
}

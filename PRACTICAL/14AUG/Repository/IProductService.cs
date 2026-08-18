using _14AUG.Model;

namespace _14AUG.Repository
{
    public interface IProductService
    {
        List<Product> GetProducts();

        Product? GetProductById(int id);

        Product AddProduct(Product product);

        Product UpdateProduct(Product product);

      
    }
}

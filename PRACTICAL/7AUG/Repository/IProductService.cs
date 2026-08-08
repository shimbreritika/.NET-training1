using _7AUG.Model;

namespace _7AUG.Repository
{
    //defines what operations are avaliable
    public interface IProductService
    {
        List<Product> GetProducts();

        Product? GetProductById(int id);

        Product AddProduct(Product product);
    }
}

using _17_AugRest.Models;

namespace _17_AugRest.Repository
{
    public interface IProductService
    {
        List<Product> GetProducts(); //fetch all product fron products table 

        Product? GetProductById(int id); //fetch product detail from products table based on PId

        void AddProduct(Product product); //add new product record in products table

        void UpdateProduct(Product product); //modify product details from products table based on PId

        void DeleteProduct(int id); //remove product record from products table based on PId
    }
}

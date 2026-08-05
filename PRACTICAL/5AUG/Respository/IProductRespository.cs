using _5AUG.Model;

namespace _5AUG.Respository
{
    //declare CURD method for product entity
    public interface IProductRespository
    {
        List<Product> GetAll();

        Product GetProduct(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}

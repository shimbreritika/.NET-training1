using _17_AugRest.Models;

namespace _17_AugRest.Repository
{
    public interface ICategoryService
    {
        List<Category> GetCategories();

        Category? GetCategoryById(int id);

        void AddCategory(Category category);
    }
}

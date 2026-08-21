using _17_AugRest.Data;
using _17_AugRest.Models;
using _17_AugRest.Repository;

namespace _17_AugRest.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext context;

        public CategoryService(AppDbContext context) { 
            
            this.context = context;
        }
        public void AddCategory(Category category)
        {
            context.categories.Add(category);
            context.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return context.categories.ToList();
        }

        public Category? GetCategoryById(int id)
        {
            return context.categories.Find(id);
        }
    }
}

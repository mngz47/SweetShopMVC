using Microsoft.AspNetCore.Mvc;

namespace mvcBlog
{
    public class CategoryRepository : ICategoryRepository
    {

        public IEnumerable<Category> GetAllCategories => new List<Category>
        {

            new Category { CategoryId = 1, CategoryName="Candy", CategoryDescription="Red"},
            new Category { CategoryId = 2, CategoryName="Choc", CategoryDescription="Blue"},
            new Category { CategoryId = 3, CategoryName="Ranchers", CategoryDescription="Green"}

        };

        public IEnumerable<Category> GetCategoriesById(int id) => new List<Category>
        {

            new Category { CategoryId = 1, CategoryName="Candy", CategoryDescription="Red"},
            new Category { CategoryId = 2, CategoryName="Choc", CategoryDescription="Blue"},
            new Category { CategoryId = 3, CategoryName="Ranchers", CategoryDescription="Green"}

        };

    }
}

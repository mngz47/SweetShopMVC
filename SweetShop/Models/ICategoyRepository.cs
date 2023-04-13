using Microsoft.AspNetCore.Mvc;

namespace mvcBlog
{
    public interface ICategoryRepository 
    {

        IEnumerable<Category> GetAllCategories { get; }


        IEnumerable<Category> GetCategoriesById(int id);


    }
}

using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace mvcBlog.Models
{

    public class SweetRepository : ISweetRepository
    {


        public IEnumerable<Sweet> GetAllSweets => new List<Sweet>
        {

            new Sweet {
                SweetId = 1,
                Name="Assorted Sweets",
                Description="A special selection of sweets",
                Price =4.55M,
                ImageUrl = "" ,
                ImageThumbnailUrl = "",
                IsOnSale= true,
                IsInStock=true,
                CategoryId=0 }

        };

        public IEnumerable<Sweet> GetSweetsOnSale => new List<Sweet>
        {

            new Sweet {
                SweetId = 1,
                Name="Assorted Sweets",
                Description="A special selection of sweets",
                Price =4.55M,
                ImageUrl = "" ,
                ImageThumbnailUrl = "",
                IsOnSale= true,
                IsInStock=true,
                CategoryId=0 }

        };


        /*Use NET5
         * Starup.cs
         * 
         * services.AddScoped<ICategoryRepository, CategoryRepository>();
         * services.AddScoped<ISweetRepository, SweetRepository>();
         * 
         */



    }
        
}

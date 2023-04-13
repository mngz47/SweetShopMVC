using Microsoft.AspNetCore.Mvc;

namespace mvcBlog
{
    public class Category 
    {

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        //property list ->> each category will contain lists of sweets
     //   public List<Sweet> Sweets { get; set; }

    }
}

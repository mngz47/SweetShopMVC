using Microsoft.AspNetCore.Mvc;

namespace mvcBlog;

public class Sweet
{
   
    public int SweetId { get; set; }    

    public string Name { get; set;}

    public string Description { get; set;}

    public decimal Price { get; set;}

    public string ImageUrl { get; set;}

    public string ImageThumbnailUrl { get; set;}

    public bool IsOnSale { get; set;}

    public bool IsInStock { get; set;}

    public int CategoryId { get; set;} 

}

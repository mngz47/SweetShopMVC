using Microsoft.AspNetCore.Mvc;

namespace mvcBlog.Models
{
    public interface ISweetRepository
    {
       
        IEnumerable<Sweet> GetAllSweets { get; }
        IEnumerable<Sweet> GetSweetsOnSale { get; } 




    }
}

using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents.Blog
{
    public class WriterBlogs : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());


        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogByWriter(1);


            return View(values);


        }
    }

   
}

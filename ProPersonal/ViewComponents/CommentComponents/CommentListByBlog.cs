using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents.CommentComponents
{
    public class CommentListByBlog : ViewComponent
    {
        //this component helps to bring the comments to the Writer dashboard

        CommentMailManager cm = new CommentMailManager(new EfCommentMailRepository());
        BlogManager bm = new BlogManager(new EfBlogRepository());



        public IViewComponentResult Invoke()
        {

            return View();
        }
        

    }
}

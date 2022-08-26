using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProPersonal.Areas.Admin.ViewComponents.Statistic
{
    public class TotalBlogStatistic : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.blogTotal = bm.GetList().Count();
            ViewBag.commentTotal = c.CommentMails.Count();

            return View();  

        }
    }
}

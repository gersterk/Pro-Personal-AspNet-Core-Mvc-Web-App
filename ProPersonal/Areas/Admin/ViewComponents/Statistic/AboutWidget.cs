using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProPersonal.Areas.Admin.ViewComponents.Statistic
{
    
    public class AboutWidget : ViewComponent
    {

        Context c = new Context();

    
        public IViewComponentResult Invoke()
        {
            ViewBag.lastBlog = c.Blogs.OrderByDescending(x=>x.BlogId).Select(x => x.BlogName).Take(1).FirstOrDefault();

            return View();

        }
    }
}

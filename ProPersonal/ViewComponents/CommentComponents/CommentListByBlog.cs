using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents.CommentComponents
{
    public class CommentListByBlog : ViewComponent
    {
        CommentMailManager cm = new CommentMailManager(new EfCommentMailRepository());
        public IViewComponentResult Invoke()
        {
            var values = cm.GetList(4);

            return View(values);
        }
    }
}

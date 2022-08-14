using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    public class CommentMailController : Controller
    {
        CommentMailManager cm = new CommentMailManager(new EfCommentMailRepository());

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AddComment()
        {
            return PartialView();

        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);

        }

        
    }
}

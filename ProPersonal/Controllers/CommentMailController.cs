using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    public class CommentMailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AddComment()
        {
            return PartialView();

        }

        public PartialViewResult CommentListByBlog()
        {
            return PartialView();

        }

        
    }
}

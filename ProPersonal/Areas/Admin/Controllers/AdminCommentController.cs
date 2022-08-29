using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Areas.Admin.Controllers
{
    public class AdminCommentController : Controller
    {
        CommentMailManager commentManager = new CommentMailManager(new EfCommentMailRepository());

        [Area("Admin")]
        public IActionResult Index()
        {
            var getcomment = commentManager.GetCommentsByBlog();

            return View(getcomment);
        }
    }
}

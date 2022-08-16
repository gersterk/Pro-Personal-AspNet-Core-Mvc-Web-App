using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ProPersonal.Controllers
{
    public class CommentMailController : Controller
    {
        CommentMailManager cm = new CommentMailManager(new EfCommentMailRepository());

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();

        }

        [HttpPost]
        public PartialViewResult AddComment(CommentMail p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.IsActiveComment = true;
            p.BlogId = 6;
            cm.CommentAdd(p);
                                        //THERES SOMETHING WRONG WITH HERE AND IDK WHAT :D CODESMELL
            return PartialView();

        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);

        }

        
    }
}

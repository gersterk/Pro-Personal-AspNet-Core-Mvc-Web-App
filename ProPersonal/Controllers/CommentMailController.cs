using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ProPersonal.Controllers
{
    [AllowAnonymous]
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
        public IActionResult AddComment(CommentMail p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.IsActiveComment = true;
            p.BlogId = 6;
            cm.CommentAdd(p);
                                        //THERES SOMETHING WRONG WITH HERE AND IDK WHAT :D CODE SMELL
            return RedirectToAction("BlogReadAll", "Blog");

        }

        public PartialViewResult CommentListByBlog(int id)
        {
            ViewBag.i = id;

            var values = cm.GetList(id);
            return PartialView(values);

        }

        
    }
}

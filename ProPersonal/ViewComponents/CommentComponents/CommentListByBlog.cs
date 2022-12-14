using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents.CommentComponents
{
    public class CommentListByBlog : ViewComponent
    {
        //this component helps to bring the comments to the Writer dashboard

        CommentMailManager cm = new CommentMailManager(new EfCommentMailRepository());



        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);

            return View(values);
        }
        

    }
}

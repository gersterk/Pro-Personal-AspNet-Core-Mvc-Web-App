using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents.Writer
{
    //This are is for bringing the comments o the writer as message...
    public class WriterMessageNotification : ViewComponent
    {
        CommentMailManager cm = new CommentMailManager(new EfCommentMailRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);

            return View(values);

        }
    }
}

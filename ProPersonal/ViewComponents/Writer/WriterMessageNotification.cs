using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents.Writer
{
    //This are is for bringing the comments o the writer as message...
    public class WriterMessageNotification : ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}

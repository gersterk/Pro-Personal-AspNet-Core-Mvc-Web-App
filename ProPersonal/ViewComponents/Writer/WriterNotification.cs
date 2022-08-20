using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}

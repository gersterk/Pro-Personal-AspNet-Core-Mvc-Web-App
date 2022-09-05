using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents
{
    public class TextEditor : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}

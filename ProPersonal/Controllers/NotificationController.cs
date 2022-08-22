using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

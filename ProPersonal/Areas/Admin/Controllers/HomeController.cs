using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

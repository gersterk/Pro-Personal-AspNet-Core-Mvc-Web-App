using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            
            return View();
        }
    }
}

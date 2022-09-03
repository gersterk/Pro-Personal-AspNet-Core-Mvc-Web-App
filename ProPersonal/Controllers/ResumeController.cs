using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    public class ResumeController : Controller
    {
       
        public IActionResult Index()
        {
         
            return View();
        }

    }
}

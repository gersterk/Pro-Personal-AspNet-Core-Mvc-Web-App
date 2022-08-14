using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    
    public class RegisterController : Controller
    {

        WriterManager wm = new WriterManager(new EfWriterRepository());


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer p)
        {
            p.IsActiveWriter = true;
            p.WriteAbout = "Deneme";
            wm.WriterAdd(p);    
            return RedirectToAction("Index", "Blog");

        }
    }
}

using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    public class AdminController : Controller
    {
        WriterManager writerManager = new WriterManager (new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AdminNavbarPartial(int id=1)
        {
            var getWriters = writerManager.TGetById(id);
            ViewBag.writerImage = getWriters.WriterImage;
            return PartialView();

        }
    }
}

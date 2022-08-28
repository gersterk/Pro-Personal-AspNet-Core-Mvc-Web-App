using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProPersonal.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();

            var userName = User.Identity.Name;
            var WriterId = c.Writers.Where(x => x.WriterMail == userName).Select(y => y.WriterId).FirstOrDefault();
            ViewBag.blogCount = c.Blogs.Where(x=>x.WriterId==WriterId).Count().ToString();

            return View();
        }
    }
}

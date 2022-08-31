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

            var userMail = User.Identity.Name;
            var WriterIdentity = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            ViewBag.blogCount = c.Blogs.Where(x=>x.WriterId==WriterIdentity).Count().ToString();

            return View();

        }
    }
}


//var userName = User.Identity.Name;

//var userMail = c.Writers.Where(x => x.WriterMail == userName).Select(y => y.WriterId).FirstOrDefault();
//var WriterIdentity = c.Writers.Where(x => x.WriterId == userMail).Select(y => y.WriterId).FirstOrDefault();
//ViewBag.blogCount = c.Blogs.Where(x => x.WriterId == WriterIdentity).Count().ToString();



//I believe shoukd be something like this
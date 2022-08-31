using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager pm = new ProjectManager(new EfProjectRepository());
        public IActionResult Index()
        {
            var values = pm.GetList();

            return View(values);
        }

        public IActionResult ProjectReadAll(int id)
        {
            var values = pm.GetProjectByIdb(id);

            return View(values);

        }
    }
}

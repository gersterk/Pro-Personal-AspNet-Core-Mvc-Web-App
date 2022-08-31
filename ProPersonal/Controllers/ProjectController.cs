using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager pm = new ProjectManager(new EfProjectRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = pm.GetList();

            return View(values);
        }

        [AllowAnonymous]
        public IActionResult ProjectReadAll(int id)
        {
            var values = pm.GetProjectByIdb(id);

            return View(values);

        }
    }
}

using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

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
        [HttpGet]
        public IActionResult ProjectAddNew()
        {
            return View();

        }

        [HttpPost]
        public IActionResult ProjectAddNew(Project p)
        {
            p.IsActiveProject = true;
            p.ProjectPublishDate = DateTime.Parse(DateTime.Now.ToLongDateString());
            pm.TAdd(p);
            // would be usefull If add ongoing or accomplished stuffs...
            return RedirectToAction("Index", "Project");
        }

        [HttpGet]
        public IActionResult ProjectEdit(int id)
        {
           var projectValues = pm.TGetById(id);
            return View(projectValues);

        }

        [HttpPost]
        public IActionResult ProjectEdit(Project p)
        {
           
            var projectUpdateTime = pm.TGetById(p.ProjectId);
            p.ProjectPublishDate = DateTime.Parse(projectUpdateTime.ProjectPublishDate.ToShortDateString());
            p.IsActiveProject =true;
            pm.TUpdate(p);  

            return RedirectToAction("ProjectListAll");

        }

        public IActionResult ProjectListAll()
        {
            var values = pm.GetList();
            return View(values);
        }
    }
}

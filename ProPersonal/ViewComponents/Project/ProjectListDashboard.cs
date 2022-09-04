using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents.Project
{
    public class ProjectListDashboard : ViewComponent
    {
        ProjectManager projectManager = new ProjectManager(new EfProjectRepository());

        public IViewComponentResult Invoke()
        {
            var values = projectManager.GetList();
            return View(values);

        }
    }
}

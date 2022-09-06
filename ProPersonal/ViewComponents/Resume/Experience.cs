using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents.Resume
{
    public class Experience : ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceRepository());
        public IViewComponentResult Invoke()
        {
            var getList = experienceManager.GetList();
            return View(getList);
        }
    }
}

using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using ProPersonal.Models;

namespace ProPersonal.ViewComponents.Resume
{
    public class Skills : ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillRepository());

        public IViewComponentResult Invoke ()
        {
            var getSkills = skillManager.GetList();
            return View(getSkills);
        }

    }
}

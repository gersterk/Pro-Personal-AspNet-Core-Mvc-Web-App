using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    public class ResumeController : Controller
    {
        BusinessCardManager bcm = new BusinessCardManager(new EfBusinessCardRepository());
        SkillManager skillManager = new SkillManager(new EfSkillRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Card(int id)
        {
            var values = bcm.TGetById(id);
            values.Id = 1;
            return View(values);
        }

        public IActionResult MySkills()
        {
            var values = skillManager.GetList(); //should come from SkillManager but theres no such yet... 
            return View(values);

        }
    }
}

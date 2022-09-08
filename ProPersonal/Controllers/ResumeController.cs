using BusinessLogicLayer.Concrete; 
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProPersonal.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {   
            return View();
        }

        [HttpGet]
        public IActionResult EditBusinessCard()
        {
            BusinessCardManager businessCardManager = new BusinessCardManager(new EfBusinessCardRepository());

            var editList = businessCardManager.TGetById(1);
            return View(editList);
        }

        [HttpPost]
        public IActionResult EditBusinessCard(BusinessCard bc)
        {
            BusinessCardManager businessCardManager = new BusinessCardManager(new EfBusinessCardRepository());
            bc.IsActive = true;
            businessCardManager.TUpdate(bc);
            return View("EditBusinessCard");
        }

        [HttpGet]
        public IActionResult UpdateSkills()
        {
            SkillManager skillManager = new SkillManager(new EfSkillRepository());
            var getSkill = skillManager.GetList();
            return View(getSkill);
        }

        [HttpPost]
        public IActionResult UpdateSkills(Skill t)
        {
            SkillManager skillManager = new SkillManager(new EfSkillRepository());
            skillManager.TUpdate(t);

            return RedirectToAction("UpdateSkills");
        }
    }
}

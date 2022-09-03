using BusinessLogicLayer.Concrete; 
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProPersonal.Controllers
{
    public class ResumeController : Controller
    {
        BusinessCardManager businessCardManager = new BusinessCardManager(new EfBusinessCardRepository());  
        SkillManager skillManager = new SkillManager(new EfSkillRepository());
       
        public IActionResult Index()
        {   
            return View();
        }

        public IActionResult Header(int id)
        {
            var results = businessCardManager.TGetById(id);
            results.Id = 1;
            ViewBag.profession = results.Profession;
            return View(results);

        }

        public IActionResult Interests()
        {
            var results = skillManager.GetList();
            return View(results);

        }

        public IActionResult Skill()
        {
            var values = skillManager.GetList();
            return View(values);

        }
        public IActionResult Portfolio()
        {
            return View();

        }
        public IActionResult Experience()
        {
            return View();

        }
    }
}

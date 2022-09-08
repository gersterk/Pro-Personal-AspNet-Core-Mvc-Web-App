using BusinessLogicLayer.Concrete; 
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProPersonal.Controllers
{
    public class ResumeController : Controller
    {
        BusinessCardManager _businessCardManager = new BusinessCardManager(new EfBusinessCardRepository());
        SkillManager _skillManager = new SkillManager(new EfSkillRepository());

        public IActionResult Index()
        {
            //index will be shown on client part
            return View();
        }

        public IActionResult DashbaordIndex()
        {

            //Will be shown on dashboard to list and edit
            return View();
        }


        [Authorize]
        [HttpGet]
        public IActionResult EditBusinessCard()
        {

            var editList = _businessCardManager.TGetById(1);
            return View(editList);
        }


        [Authorize]
        [HttpPost]
        public IActionResult EditBusinessCard(BusinessCard bc)
        {
            bc.IsActive = true;
            _businessCardManager.TUpdate(bc);
            return View("DashbaordIndex");
        }


        [Authorize]
        [HttpGet]
        public IActionResult UpdateSkills()
        {
            var getSkill = _skillManager.GetList();
            return View(getSkill);
        }


        [Authorize]
        [HttpPost]
        public IActionResult UpdateSkills(Skill t)
        {
            _skillManager.TUpdate(t);
            return RedirectToAction("DashbaordIndex");
        }



    }
}

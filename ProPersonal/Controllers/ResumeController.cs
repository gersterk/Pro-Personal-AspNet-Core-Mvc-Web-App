using BusinessLogicLayer.Concrete; 
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProPersonal.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProPersonal.Controllers
{
    public class ResumeController : Controller
    {
        BusinessCardManager _businessCardManager = new BusinessCardManager(new EfBusinessCardRepository());
        SkillManager _skillManager = new SkillManager(new EfSkillRepository());
        ExperienceManager _experienceManager = new ExperienceManager(new EfExperienceRepository());

        public IActionResult Index()
        {
            //index will be shown on client part
            return View();
        }

        [Authorize]
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

            
            List<SelectListItem> skillsToSelect = (from list in _skillManager.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = list.Name,
                                                       Value = list.Id.ToString()
                                                   }).ToList();

            ViewBag.listedSkills = skillsToSelect;


            return View();
        }


        [Authorize]
        [HttpPost]
        public IActionResult UpdateSkills(Skill t)
        {
            //this should be updated by id
            t.IsActive = true;
            _skillManager.TUpdate(t);
            return RedirectToAction("DashbaordIndex");
        }

        [Authorize]
        [HttpGet]
        public IActionResult ListExperience()
        {
            var experience = _experienceManager.GetList();
            return View(experience);

            //the method will display the list of work experiences on dashboard
        }

        [Authorize]
        [HttpGet]
        public IActionResult AddExperience()
        {
            var experience = _experienceManager.GetList();
            return View(experience);
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddExperience(Experience exp)
        {
            exp.IsActive = true;
            _experienceManager.TAdd(exp);
            return View("DashbaordIndex");
        }

        [Authorize]
        [HttpGet]
        public IActionResult EditExperience(int id)
        {

            var getValues = _experienceManager.TGetById(id);


            List<SelectListItem> expValues = (from x in _experienceManager.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Position,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            
            ViewBag.listExperience = expValues;

            return View(getValues);
        }

        [Authorize]
        [HttpPost]
        public IActionResult EditExperience(Experience exp)
        {
            exp.IsActive = true;
            _experienceManager.TUpdate(exp);
            return View("DashbaordIndex");
        }


        //I will not have an action of deleting because editing will be enough


        //portfolio


        // then the whole editing part

    }
}

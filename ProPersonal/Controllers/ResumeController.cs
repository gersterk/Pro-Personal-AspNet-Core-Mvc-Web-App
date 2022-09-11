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
    [Authorize]
    public class ResumeController : Controller
    {
        BusinessCardManager _businessCardManager = new BusinessCardManager(new EfBusinessCardRepository());
        SkillManager _skillManager = new SkillManager(new EfSkillRepository());
        ExperienceManager _experienceManager = new ExperienceManager(new EfExperienceRepository());
        PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolioRepository());
        [AllowAnonymous]
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

        [HttpGet]
        public IActionResult EditBusinessCard()
        {

            var editList = _businessCardManager.TGetById(1);
            return View(editList);
        }


        [HttpPost]
        public IActionResult EditBusinessCard(BusinessCard bc)
        {
            bc.IsActive = true;
            _businessCardManager.TUpdate(bc);
            return View("DashbaordIndex");
        }



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



        [HttpPost]
        public IActionResult UpdateSkills(Skill t)
        {
            //this should be updated by id
            t.IsActive = true;
            _skillManager.TUpdate(t);
            return RedirectToAction("DashbaordIndex");
        }

    
        [HttpGet]
        public IActionResult ListExperience()
        {
            var experience = _experienceManager.GetList();
            return View(experience);

            //the method will display the list of work experiences on dashboard
        }

   
        [HttpGet]
        public IActionResult AddExperience()
        {
            var experience = _experienceManager.GetList();
            return View(experience);
        }

        [HttpPost]
        public IActionResult AddExperience(Experience exp)
        {
            exp.IsActive = true;
            _experienceManager.TAdd(exp);
            return View("DashbaordIndex");
        }

        
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

        
        [HttpPost]
        public IActionResult EditExperience(Experience exp)
        {
            exp.IsActive = true;
            _experienceManager.TUpdate(exp);
            return View("DashbaordIndex");
        }


        //I will not have an action of deleting because editing will be enough




        //portfolio
        [HttpGet]
        public IActionResult GetPorfolio()
        {
            var values = _portfolioManager.GetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var values = _portfolioManager.TGetById(id);

            List<SelectListItem> selectListItems = (from x in _portfolioManager.GetList()
                                                    select new SelectListItem
                                                    {

                                                        Text = x.Name,
                                                        Value = x.Id.ToString()

                                                    }).ToList();
            ViewBag.portfolio = selectListItems;

            return View();
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio p)
        {
            p.IsActive = true;

            _portfolioManager.TUpdate(p);
            return View("GetPorfolio");
        }

        // then the whole editing part

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            p.IsActive = true;
            _portfolioManager.TAdd(p);
            return View("GetPorfolio");
        }
    }
}

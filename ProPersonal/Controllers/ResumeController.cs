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
        public IActionResult EditBusinessCard(int id=1)
        {
            BusinessCardManager businessCardManager = new BusinessCardManager(new EfBusinessCardRepository());

            var editList = businessCardManager.TGetById(id);
            return View(editList);
        }

        [HttpPost]
        public IActionResult EditBusinessCard(BusinessCard bc)
        {
            BusinessCardManager businessCardManager = new BusinessCardManager(new EfBusinessCardRepository());

            businessCardManager.TUpdate(bc);
            return View("EditBusinessCard");
        }
    }
}

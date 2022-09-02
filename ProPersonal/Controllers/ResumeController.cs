using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    public class ResumeController : Controller
    {
        BusinessCardManager bcm = new BusinessCardManager(new EfBusinessCardRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Card(int id)
        {
            var values = bcm.TGetById(id);

            return View(values);
        }

        public PartialViewResult MySkills()
        {
            var values = bcm.GetList();
            return PartialView(values);

        }
    }
}

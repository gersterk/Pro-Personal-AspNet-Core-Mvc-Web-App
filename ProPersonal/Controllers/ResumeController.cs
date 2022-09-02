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

        public IActionResult Card()
        {
            var values = bcm.GetList();
            return View(values);
        }

    }
}

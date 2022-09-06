using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents.Resume
{
    public class Interest : ViewComponent
    {
        InterestManager interestManager = new InterestManager(new EfInterestRepository());

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

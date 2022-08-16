using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents
{
    public class Subscribe : ViewComponent
    {
        NewsletterManager nm = new NewsletterManager(new EfNewsletterRepository());

        public IViewComponentResult Invoke()
        {
            //var values = nm.AddNewsletter(p);
            return View();
        }
    }
}

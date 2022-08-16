using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    public class NewsletterController : Controller
    {
        NewsletterManager nm = new NewsletterManager(new EfNewsletterRepository());
       
        
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(Newsletter p)
        {
            p.IsActiveMail = true;
            nm.AddNewsletter(p);
            return PartialView();
        }
    }
}

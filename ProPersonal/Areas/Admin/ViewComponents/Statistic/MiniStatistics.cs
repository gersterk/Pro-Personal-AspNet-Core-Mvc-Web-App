using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProPersonal.Areas.Admin.ViewComponents.Statistic
{
    public class MiniStatistics : ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.adminName = c.Admins.Where(x => x.AdminId == 1).Select(y => y.Name).FirstOrDefault();
            ViewBag.adminImage = c.Admins.Where(x=>x.AdminId==1).Select(y => y.ImageUrl).FirstOrDefault();

            return View();

        }
    }
}

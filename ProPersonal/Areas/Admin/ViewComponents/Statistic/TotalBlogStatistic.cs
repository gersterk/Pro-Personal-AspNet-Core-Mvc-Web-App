using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace ProPersonal.Areas.Admin.ViewComponents.Statistic
{
    public class TotalBlogStatistic : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.blogTotal = bm.GetList().Count();
            ViewBag.commentTotal = c.CommentMails.Count();

            string api = "39a5fb44446ea15aaaf17aa90fd018fa";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=bratislava&mode=xml&lang=eng&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);  
            ViewBag.weatherInfo = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();  

        }
    }
}

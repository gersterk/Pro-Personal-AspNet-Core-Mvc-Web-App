using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProPersonal.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = cm.GetList();
            return View(values);  
        }

        public IViewComponentResult CategoryListCount()
        {
            var count = cm.GetList().Count();
            ViewBag.categoryCount = count;

            return View(count);
        }
    }
}

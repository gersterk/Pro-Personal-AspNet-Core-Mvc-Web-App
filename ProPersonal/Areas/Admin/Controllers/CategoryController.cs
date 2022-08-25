using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace ProPersonal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index(int page=1) // int page for pagination
        {
            var values = cm.GetList().ToPagedList(page,10); //page is initiation and 10 is its size will hold number of the items in each page 

            return View(values);
        }
    }
}

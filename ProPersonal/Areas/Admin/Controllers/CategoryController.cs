using BusinessLogicLayer.Concrete;
using BusinessLogicLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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


        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();

        }
        
        [HttpPost]
        public IActionResult AddCategory(Category p )
        {

            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(p);


            if (results.IsValid)
            {

                p.IsActiveCategory = true;
                cm.TAdd(p);

                return RedirectToAction("Index", "Category");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }
    }
}

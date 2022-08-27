using Microsoft.AspNetCore.Mvc;
using ProPersonal.Areas.Admin.Models;
using System.Collections.Generic;

namespace ProPersonal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart() //static chart
        {
            List<CategoryModel> listCategory = new List<CategoryModel>();
            listCategory.Add(new CategoryModel
            {
                CategoryCount = 10,
                CategoryName = "Technology",
            });
            listCategory.Add(new CategoryModel
            {
                CategoryCount = 18,
                CategoryName = "Software",
            });
            listCategory.Add(new CategoryModel
            {
                CategoryCount = 4,
                CategoryName = "Philosophy",
            });

            return Json(new {jsonlist=listCategory});


        }
    }
}

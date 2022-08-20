using BusinessLogicLayer.Concrete;
using BusinessLogicLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProPersonal.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListByCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogById(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var values = bm.GetListByCategoryWithWriterBm(1);

            return View(values);

        }

        [HttpGet]
        public IActionResult BlogAddNew()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());

            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
           //this function lists the value comes from category by id to string and the name of it as kind of dropdown
           ViewBag.cv = categoryvalues;

            return View();


        }

        [HttpPost]
        public IActionResult BlogAddNew(Blog p)
        {

            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {

                p.IsActiveBlog = true;
                p.PublishDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterId = 1;
                bm.TAdd(p);

                return RedirectToAction("BlogListByWriter", "Blog");

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

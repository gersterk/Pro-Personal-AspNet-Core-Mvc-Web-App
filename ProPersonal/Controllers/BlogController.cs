using BusinessLogicLayer.Concrete;
using BusinessLogicLayer.ValidationRules;
using DataAccessLayer.Concrete;
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
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        Context c = new Context();
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
           // i dont Know this is not very healty and doesnt abide to SOLID but Ive got no a better solution yet
            //refactoring is coming
            var userMail = User.Identity.Name;
            var WriterId = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var values = bm.GetListByCategoryWithWriterBm(WriterId);

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
                var userMail = User.Identity.Name;
                var WriterId = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
                p.IsActiveBlog = true;
                p.PublishDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterId = WriterId;

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

        public IActionResult DeleteBlog(int id)
        {
            var blogvalues = bm.TGetById(id);
            bm.TDelete(blogvalues);

            return RedirectToAction("BlogListByWriter");
             
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {


            var blogvalues = bm.TGetById(id);
            

            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            //this function lists the value comes from category by id to string and the name of it as kind of dropdown
            ViewBag.cv = categoryvalues;

            return View(blogvalues);

        }

        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            var userMail = User.Identity.Name;
            var WriterId = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var blogvalue = bm.TGetById(p.BlogId);

            p.WriterId = WriterId;
            p.PublishDate = DateTime.Parse(blogvalue.PublishDate.ToShortDateString()); //keeps the publish date as it was 
            p.IsActiveBlog = true;

            bm.TUpdate(p);



            //BlogValidator bv = new BlogValidator();
            //ValidationResult validationResult = bv.Validate(p);

            //if (validationResult.IsValid)
            //{

            //    p.IsActiveBlog = true;
            //    p.PublishDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            //    bm.TUpdate(p);

            //    return RedirectToAction("BlogListByWriter", "Blog");

            //}
            //else
            //{
            //    foreach (var item in validationResult.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
        
            return RedirectToAction("BlogListByWriter");

        }

    }
}

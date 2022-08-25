using BusinessLogicLayer.Concrete;
using BusinessLogicLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProPersonal.Models;
using System;
using System.IO;
using System.Linq;

namespace ProPersonal.Controllers
{
  
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [Authorize]
        public IActionResult Index()
        {
            var usermail = User.Identity.Name; //brings the current user's details like username or email
            //User.Identity comes from Claims Principals Class from IPrincipal
            ViewBag.v1 = usermail;

            Context c = new Context();
            var writerName = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.v2 = writerName;



            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult WriterNavbarPartial()
        {
            return View();

        }

        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();

        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var writervalues = wm.TGetById(1);
            return View(writervalues);

        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            WriterValidations wl = new WriterValidations();
            ValidationResult result = wl.Validate(p);

            if (result.IsValid)
            {
                wm.TUpdate(p);
                return RedirectToAction("Index", "Dashboard");            
            }


            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }
            return View();

        }
        
        [AllowAnonymous]
        [HttpGet]       
        public IActionResult WriterAdd()  //this methods is for adding images to the writer's profile... The name is missing...
        {
            return View();

        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();

            if (p.WriterImage != null)
            {
                //gets the path of the image
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension; //name the file into the writer image folde with a guid and its name
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFile/",newimagename);
                var stream = new FileStream(location, FileMode.Create); //creats the full path
                p.WriterImage.CopyTo(stream); //copies to it
                w.WriterImage = newimagename;

            }
            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.IsActiveWriter = true;
            w.WriteAbout = p.WriteAbout;

            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
            
        }
    }
}

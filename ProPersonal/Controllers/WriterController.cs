using BusinessLogicLayer.Concrete;
using BusinessLogicLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProPersonal.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProPersonal.Controllers
{

    [Authorize]
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        UserManager userManager = new UserManager(new EfUserRepository());


        private readonly UserManager<AppUser> _userManager;


        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }



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


        public IActionResult WriterNavbarPartial()   // this should be bringing picture and photo but Idk why doesnt
        {
   
            return View();

        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();

        }



        [HttpGet]
        public async Task<IActionResult> WriterEditProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateModel model = new UserUpdateModel();

            model.mail = values.Email;
            model.namesurname = values.NameSurname;
            model.username = values.UserName;
            model.imageurl = values.ImageUrl;


            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateModel model)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.NameSurname = model.namesurname;
            values.UserName = model.username;
            values.ImageUrl = model.imageurl;
            values.Email = model.mail;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.password);
            var result = await _userManager.UpdateAsync(values);
            return RedirectToAction("index", "Dashboard");

        }




        [HttpGet]
        public IActionResult WriterAdd()  //this methods is for adding images to the writer's profile... The name is missing...
        {
            return View();

        }

        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();

            if (p.WriterImage != null)
            {
                //gets the path of the image
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension; //name the file into the writer image folder with a guid and its name
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFile/", newimagename);
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

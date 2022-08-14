using BusinessLogicLayer.Concrete;
using BusinessLogicLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;


namespace ProPersonal.Controllers
{
    
    public class RegisterController : Controller
    {

        WriterManager wm = new WriterManager(new EfWriterRepository());


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WriterValidations wv = new WriterValidations();
            ValidationResult results = wv.Validate(p);
            if (results.IsValid)
            {

                p.IsActiveWriter = true;
                p.WriteAbout = "Deneme";
                wm.WriterAdd(p);
                return RedirectToAction("Index", "Blog");

            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }
    }
}

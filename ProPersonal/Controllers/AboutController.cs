﻿using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        AboutManager ab = new AboutManager(new EfAboutRepository());


        public IActionResult Index()
        {
            var values = ab.GetList();
            return View(values);
        }
        public PartialViewResult SocialMediaAbout()
        {

            return PartialView();

        }
    }
}

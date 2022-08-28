﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProPersonal.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProPersonal.Controllers
{

    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signinManager;

        public LoginController(SignInManager<AppUser> signinManager)
        {
            _signinManager = signinManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginModel p )
        {   //if email will not work, go for username
            if (ModelState.IsValid)
            {
              
                var results = await _signinManager.PasswordSignInAsync(p.UserName, p.UserPassword, false, false);
                if (results.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    return View("Index", "Login");  
                }
            }
            return View();


        }



        //[HttpPost]
        //public async Task <IActionResult> Index(Writer p)
        //{
        //    Context c = new Context();
        //    var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
        //    if(datavalue !=null)
        //    {
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name,p.WriterMail)
        //        };
        //        var useridentity = new ClaimsIdentity(claims, "a");
        //        ClaimsPrincipal  principal= new ClaimsPrincipal(useridentity);
        //        await HttpContext.SignInAsync(principal);

        //        return RedirectToAction("Index", "Dashboard");
        //    }
        //    else
        //    {
        //        return View();
        //    }



        ////    Context c = new Context();
        ////    var datavalues = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
        ////    if(datavalues != null)
        ////    {
        ////        HttpContext.Session.SetString("username", p.WriterMail);
        ////        return RedirectToAction("Index", "Writer");
        ////    }

        ////    else
        ////    {
        ////        return View();
        ////    }

        //}
    }
}

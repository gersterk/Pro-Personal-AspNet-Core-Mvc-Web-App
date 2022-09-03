using BusinessLogicLayer.Concrete; 
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProPersonal.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {   
            return View();
        }

     
    }
}

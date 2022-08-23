using Microsoft.AspNetCore.Mvc;
using ProPersonal.Models;
using System.Collections.Generic;

namespace ProPersonal.ViewComponents.CommentComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    

    }
}

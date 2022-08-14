using Microsoft.AspNetCore.Mvc;
using ProPersonal.Models;
using System.Collections.Generic;

namespace ProPersonal.ViewComponents
{ 
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        var commentvalues = new List<ClientComment>
            {
                new ClientComment
                {
                    Id = 1,
                    UserName="meaw"

                }
            };
            return View(commentvalues);
        }
    }
}

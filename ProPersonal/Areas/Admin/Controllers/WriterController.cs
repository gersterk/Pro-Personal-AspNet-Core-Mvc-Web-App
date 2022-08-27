using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProPersonal.Areas.Admin.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProPersonal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }
        public IActionResult GetWriterById(int writerId)
        {
            var findWriter = writers.FirstOrDefault(x=>x.Id== writerId);  
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);

        }

        public static List<WriterModel> writers = new List<WriterModel>
        {
            new WriterModel
            {
                Id=1,
                Name="Ayse"
            },

            new WriterModel
            {
                Id=2,
                Name="Fatma"
            }

        };

    }
}

using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using ProPersonal.Areas.Admin.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProPersonal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            using(var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blogs List");
                worksheet.Cell(1, 1).Value = "Blog Id";
                worksheet.Cell(1, 2).Value = "Blog Name";


                int blogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(blogRowCount, 1).Value = item.Id;
                    worksheet.Cell(blogRowCount, 2).Value = item.BlogTitle;
                    blogRowCount++;


                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Blogs.xlsx");

                }

            }
        }

        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
                new BlogModel{Id=1, BlogTitle="Test Row"}, new BlogModel{Id=2, BlogTitle="testtt"}


            };
            return bm;

        }

        public IActionResult BlogListExcel()
        {
            return View();

        }

        //the methods above were a try get the names statically... even though I know I could be confusing, I will not delete them :)
        //I couldnt comprehend yet xd

        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blogs List");
                worksheet.Cell(1, 1).Value = "Blog Id";
                worksheet.Cell(1, 2).Value = "Blog Name";


                int blogRowCount = 2;
                foreach (var item in BlogListExcelDynamic())
                {
                    worksheet.Cell(blogRowCount, 1).Value = item.Id;
                    worksheet.Cell(blogRowCount, 2).Value = item.BlogTitle;
                    blogRowCount++;


                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Blogs.xlsx");

                }

            }
        }

        public List<BlogModel2> BlogListExcelDynamic()
        {
            List<BlogModel2> bm = new List<BlogModel2>();
            using(var c = new Context())
            {
                bm = c.Blogs.Select(x => new BlogModel2
                {
                    Id = x.BlogId,
                    BlogTitle = x.BlogName
                    
                }).ToList();

            }
            return bm;

        }
        public IActionResult BlogTitleListExcel()
        {
            return View();

        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProPersonalApi.DataAccessLayer;
using System.Linq;

namespace ProPersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Employees.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult EmployeeAdd()
        {
            return Ok();

        }
    }
}

using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProPersonal.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProPersonal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminRoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public AdminRoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        //RoleManager comes from Aspnetcore Identity



        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleModel roleModel)
        {
            if (ModelState.IsValid)
            {
                AppRole role = new AppRole
                {
                    Name = roleModel.name

                };

            var results = await _roleManager.CreateAsync(role);

                if (results.Succeeded)
                {
                    return RedirectToAction("Index");   
                }
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(roleModel);

        }

        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x=>x.Id==id);
            RoleUpdateModel model = new RoleUpdateModel
            {
                Id = values.Id,
                name = values.Name,
            };
            return View(model);


        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(RoleUpdateModel roleUpdateModel)
        {
            var values = _roleManager.Roles.Where(x => x.Id == roleUpdateModel.Id).FirstOrDefault();

            values.Name = roleUpdateModel.name;
            
            var results = await _roleManager.UpdateAsync(values);

            if (results.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View(roleUpdateModel);


        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            var result = await _roleManager.DeleteAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");

            }
            return View();
                

        }
    }
}

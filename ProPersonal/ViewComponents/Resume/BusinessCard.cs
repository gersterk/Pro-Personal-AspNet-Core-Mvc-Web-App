using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents.Resume
{
    public class BusinessCard : ViewComponent 
    {
        BusinessCardManager businessCM= new BusinessCardManager(new EfBusinessCardRepository());

        public IViewComponentResult Invoke(int id=1)
        {
            var getListAll = businessCM.TGetById(id);

            return View(getListAll);
        }
    }
}

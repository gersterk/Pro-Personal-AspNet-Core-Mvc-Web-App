using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProPersonal.ViewComponents.Resume
{
    public class Portfolio : ViewComponent
    {
        PortfolioManager portfolio = new PortfolioManager(new EfPortfolioRepository());
        public IViewComponentResult Invoke()
        {
            var getPortfolio = portfolio.GetList();

            return View(getPortfolio);
        }
    }
}

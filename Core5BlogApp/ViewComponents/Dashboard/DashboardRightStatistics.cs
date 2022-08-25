using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.Dashboard
{
    public class DashboardRightStatistics : ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioRepository());
        ServiceManager serviceManager = new ServiceManager(new EfServiceRepository());
        InterestManager interestManager = new InterestManager(new EfInterestRepository());

        public IViewComponentResult Invoke()
        {
            ViewBag.PortfolioCount = portfolioManager.TGetList().Count();
            ViewBag.ServiceCount = serviceManager.TGetList().Count();
            ViewBag.InterestCount = interestManager.TGetList().Count();
            return View();
        }

    }
}

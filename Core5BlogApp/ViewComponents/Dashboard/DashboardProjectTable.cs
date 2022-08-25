using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.Dashboard
{
    public class DashboardProjectTable : ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioRepository());
        public IViewComponentResult Invoke()
        {
            var list = portfolioManager.TGetList().Take(6).ToList();
            return View(list);
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.Home
{
    public class HomeList : ViewComponent
    {
        HomeManager homeManager = new HomeManager(new EfHomeRepository());
        public IViewComponentResult Invoke()
        {
            var list = homeManager.TGetList();
            return View(list);
        }
    }
}

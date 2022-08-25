using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.AboutComponent
{
    public class AboutComponentList : ViewComponent
    {
        AboutComponentManager aboutComponentManager = new AboutComponentManager(new EfAboutComponentRepository());

        public IViewComponentResult Invoke()
        {
            var list = aboutComponentManager.TGetList();
            return View(list);
        }

    }
}

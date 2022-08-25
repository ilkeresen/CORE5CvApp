using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.Interests
{
    public class InterestList : ViewComponent
    {
        InterestManager ınterestManager = new InterestManager(new EfInterestRepository());

        public IViewComponentResult Invoke()
        {
            var list = ınterestManager.TGetList();
            return View(list);
        }
    }
}

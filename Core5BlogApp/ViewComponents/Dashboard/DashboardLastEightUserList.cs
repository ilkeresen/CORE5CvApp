using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.Dashboard
{
    public class DashboardLastEightUserList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var list = context.Users.Where(x => x.UserName != "admin").OrderByDescending(x => x.Id).Take(8).ToList();
            return View(list);
        }
    }
}

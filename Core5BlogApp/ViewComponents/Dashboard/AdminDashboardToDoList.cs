using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.Dashboard
{
    public class AdminDashboardToDoList : ViewComponent
    {
        ToDoManager toDoManager = new ToDoManager(new EfToDoRepository());

        public IViewComponentResult Invoke()
        {
            var email = HttpContext.Session.GetString("Mail");
            var list = toDoManager.TGetList().Where(x => x.Mail == email).OrderByDescending(x=>x.Date).ToList();
            return View(list);
        }
    }
}

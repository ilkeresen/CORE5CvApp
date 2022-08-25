using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize(Roles = "Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name).Result;
            //statistics
            Context context = new Context();
            ViewBag.MessageCount = context.WriterMessages.Where(x=>x.Receiver == values.Email && x.Status == true).Count();
            ViewBag.AnnouncementCount = context.Announcements.Count();
            ViewBag.UserCount = context.Users.Count();
            ViewBag.SkillCount = context.WriterMessages.Where(x => x.Sender == values.Email && x.Status == true).Count();

            ViewBag.MainPageName = "Dashboard";
            ViewBag.PageName = "Index";
            ViewData["DashboardActive"] = "active";
            return View();
        }
    }
}

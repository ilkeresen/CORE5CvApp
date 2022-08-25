using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        HomeManager homeManager = new HomeManager(new EfHomeRepository());
        public IActionResult Index()
        {
            ViewBag.MainPageName = "Öne Çıkanlar";
            ViewBag.PageName = "Öne Çıkan Listesi";
            var list = homeManager.TGetList();
            ViewData["HomeActive"] = "active";
            return View(list);
        }

        [HttpPost]
        public JsonResult HomeDelete(int id)
        {
            var home = homeManager.TGetByID(id);

            if (home != null)
            {
                homeManager.TDelete(home);
            }

            return Json(home);
        }

        [HttpPost]
        public JsonResult HomeAdd(Home home)
        {
            var homeListCount = homeManager.TGetList().Count();

            if (homeListCount >= 1)
            {
                return Json(false);
            }

            homeManager.TAdd(home);

            return Json(home);
        }

        [HttpPost]
        public JsonResult HomeGetItem(int id)
        {
            var home = JsonConvert.SerializeObject(homeManager.TGetByID(id));
            return Json(home);
        }

        [HttpPost]
        public JsonResult HomeUpdate(Home home)
        {
            if (home != null)
            {
                homeManager.TUpdate(home);
            }

            return Json(home);
        }
    }
}

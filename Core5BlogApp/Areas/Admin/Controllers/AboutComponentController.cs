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
    public class AboutComponentController : Controller
    {
        AboutComponentManager _aboutComponentManager = new AboutComponentManager(new EfAboutComponentRepository());

        public IActionResult Index()
        {
            ViewBag.MainPageName = "Hakkımda Verilerim";
            ViewBag.PageName = "Hakkımda Verilerim Listesi";
            ViewData["AboutComponentActive"] = "active";
            var list = _aboutComponentManager.TGetList();
            return View(list);
        }

        [HttpPost]
        public JsonResult AboutComponentDelete(int id)
        {
            var aboutComponent = _aboutComponentManager.TGetByID(id);

            if (aboutComponent != null)
            {
                _aboutComponentManager.TDelete(aboutComponent);
            }

            return Json(aboutComponent);
        }

        [HttpPost]
        public JsonResult AboutComponentAdd(AboutComponent aboutComponent)
        {
            if (aboutComponent != null)
            {
                _aboutComponentManager.TAdd(aboutComponent);
            }

            return Json(aboutComponent);
        }

        [HttpPost]
        public JsonResult AboutComponentGetItem(int id)
        {
            var aboutComponent = JsonConvert.SerializeObject(_aboutComponentManager.TGetByID(id));
            return Json(aboutComponent);
        }

        [HttpPost]
        public JsonResult AboutComponentUpdate(AboutComponent aboutComponent)
        {
            if (aboutComponent != null)
            {
                _aboutComponentManager.TUpdate(aboutComponent);
            }

            return Json(aboutComponent);
        }
    }
}

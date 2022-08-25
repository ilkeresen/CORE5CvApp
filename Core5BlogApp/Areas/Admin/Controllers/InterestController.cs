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
    public class InterestController : Controller
    {
        InterestManager ınterestManager = new InterestManager(new EfInterestRepository());
        public IActionResult Index()
        {
            ViewBag.MainPageName = "İlgi Alanlarım";
            ViewBag.PageName = "İlgi Alanlarım Listesi";
            ViewData["InterestActive"] = "active";
            var list = ınterestManager.TGetList();
            return View(list);
        }

        [HttpPost]
        public JsonResult InterestDelete(int id)
        {
            var ınterest = ınterestManager.TGetByID(id);

            if (ınterest != null)
            {
                ınterestManager.TDelete(ınterest);
            }

            return Json(ınterest);
        }

        [HttpPost]
        public JsonResult InterestAdd(Interest ınterest)
        {
            if (ınterest != null)
            {
                ınterestManager.TAdd(ınterest);
            }

            return Json(ınterest);
        }

        [HttpPost]
        public JsonResult InterestGetItem(int id)
        {
            var ınterest = JsonConvert.SerializeObject(ınterestManager.TGetByID(id));
            return Json(ınterest);
        }

        [HttpPost]
        public JsonResult InterestUpdate(Interest ınterest)
        {
            if (ınterest != null)
            {
                ınterestManager.TUpdate(ınterest);
            }

            return Json(ınterest);
        }
    }
}

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
using X.PagedList;

namespace Core5BlogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AnnouncementController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementRepository());
        public IActionResult Index(int page = 1 , int pageSize =4)
        {
            var list = announcementManager.TGetList().OrderByDescending(x=>x.Id).ToPagedList(page, pageSize);
            ViewBag.MainPageName = "Duyurular";
            ViewBag.PageName = "Duyurular Listesi";
            ViewData["AnnouncementActive"] = "active";
            return View(list);
        }

        [HttpPost]
        public JsonResult AnnouncementDelete(int id)
        {
            var announcement = announcementManager.TGetByID(id);

            if (announcement != null)
            {
                announcementManager.TDelete(announcement);
            }

            return Json(announcement);
        }

        [HttpPost]
        public JsonResult AnnouncementAdd(Announcement announcement)
        {
            if (announcement != null)
            {
                announcement.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                announcementManager.TAdd(announcement);
            }

            return Json(announcement);
        }

        [HttpPost]
        public JsonResult AnnouncementGetItem(int id)
        {
            var announcement = JsonConvert.SerializeObject(announcementManager.TGetByID(id));
            return Json(announcement);
        }

        [HttpPost]
        public JsonResult AnnouncementUpdate(Announcement announcement)
        {
            if (announcement != null)
            {
                announcement.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                announcementManager.TUpdate(announcement);
            }

            return Json(announcement);
        }
    }
}

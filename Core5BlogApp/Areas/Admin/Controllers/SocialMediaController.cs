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
    public class SocialMediaController : Controller
    {
        SocialMediaManager _socialMediaManager = new SocialMediaManager(new EfSocialMediaRepository());
        public IActionResult Index()
        {
            ViewBag.MainPageName = "Sosyal Medya Hesaplarım";
            ViewBag.PageName = "Sosyal Medya Hesaplarım";
            ViewData["SocialMediaActive"] = "active";
            var list = _socialMediaManager.TGetList();
            return View(list);
        }

        [HttpPost]
        public JsonResult SocialMediaDelete(int id)
        {
            var socialMedia = _socialMediaManager.TGetByID(id);

            if (socialMedia != null)
            {
                _socialMediaManager.TDelete(socialMedia);
            }

            return Json(socialMedia);
        }

        [HttpPost]
        public JsonResult SocialMediaAdd(SocialMedia socialMedia)
        {
            if (socialMedia != null)
            {
                socialMedia.SocialMediaStatus = true;
                _socialMediaManager.TAdd(socialMedia);
            }

            return Json(socialMedia);
        }

        [HttpPost]
        public JsonResult SocialMediaGetItem(int id)
        {
            var socialMedia = JsonConvert.SerializeObject(_socialMediaManager.TGetByID(id));
            return Json(socialMedia);
        }

        [HttpPost]
        public JsonResult SocialMediaUpdate(SocialMedia socialMedia)
        {
            var socialMediaStatus = _socialMediaManager.TGetByID(socialMedia.SocialMediaID);
            if (socialMedia != null)
            {
                socialMedia.SocialMediaStatus = socialMediaStatus.SocialMediaStatus;
                _socialMediaManager.TUpdate(socialMedia);
            }

            return Json(socialMedia);
        }

        [HttpPost]
        public JsonResult SocialMediaVitrinAdd(int id)
        {
            var socialMedia = _socialMediaManager.TGetByID(id);
            if (socialMedia != null)
            {
                socialMedia.SocialMediaStatus = true;
                _socialMediaManager.TUpdate(socialMedia);
            }

            return Json(socialMedia);
        }

        [HttpPost]
        public JsonResult SocialMediaVitrinDelete(int id)
        {
            var socialMedia = _socialMediaManager.TGetByID(id);
            if (socialMedia != null)
            {
                socialMedia.SocialMediaStatus = false;
                _socialMediaManager.TUpdate(socialMedia);
            }

            return Json(socialMedia);
        }
    }
}

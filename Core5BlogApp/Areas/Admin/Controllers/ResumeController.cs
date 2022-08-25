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
    public class ResumeController : Controller
    {
        ResumeManager resumeManager = new ResumeManager(new EfResumeRepository());
        public IActionResult Index()
        {
            ViewBag.MainPageName = "Özgeçmişim";
            ViewBag.PageName = "Özgeçmiş Listesi";
            ViewData["ResumeActive"] = "active";
            var list = resumeManager.TGetList();
            return View(list);
        }

        [HttpPost]
        public JsonResult ResumeDelete(int id)
        {
            var skill = resumeManager.TGetByID(id);

            if (skill != null)
            {
                resumeManager.TDelete(skill);
            }

            return Json(skill);
        }

        [HttpPost]
        public JsonResult ResumeAdd(Resume resume)
        {
            if (resume != null)
            {
                resumeManager.TAdd(resume);
            }

            return Json(resume);
        }

        [HttpPost]
        public JsonResult ResumeGetItem(int id)
        {
            var resume = JsonConvert.SerializeObject(resumeManager.TGetByID(id));
            return Json(resume);
        }

        [HttpPost]
        public JsonResult ResumeUpdate(Resume resume)
        {
            if (resume != null)
            {
                resumeManager.TUpdate(resume);
            }

            return Json(resume);
        }
    }
}

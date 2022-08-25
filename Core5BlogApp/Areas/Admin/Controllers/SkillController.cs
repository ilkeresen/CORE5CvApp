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
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillRepository());
        public IActionResult Index()
        {
            ViewBag.MainPageName = "Yeneteklerim";
            ViewBag.PageName = "Yetenek Listesi";
            ViewData["SkillActive"] = "active";
            var list = skillManager.TGetList();
            return View(list);
        }

        [HttpPost]
        public JsonResult SkillDelete(int id)
        {
            var skill = skillManager.TGetByID(id);

            if (skill != null)
            {
                skillManager.TDelete(skill);
            }

            return Json(skill);
        }

        [HttpPost]
        public JsonResult SkillAdd(Skill skill)
        {
            if (skill != null)
            {
                skillManager.TAdd(skill);
            }

            return Json(skill);
        }

        [HttpPost]
        public JsonResult SkillGetItem(int id)
        {
            var skill = JsonConvert.SerializeObject(skillManager.TGetByID(id));
            return Json(skill);
        }

        [HttpPost]
        public JsonResult SkillUpdate(Skill skill)
        {
            if (skill != null)
            {
                skillManager.TUpdate(skill);
            }

            return Json(skill);
        }
    }
}

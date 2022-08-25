using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TestimonialController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public TestimonialController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewBag.MainPageName = "Yorumlarım";
            ViewBag.PageName = "Yorumlarım";
            ViewData["TestimonialActive"] = "active";
            Context context = new Context();
            var list = context.Users.Where(x=>x.Job != null && x.Content != null).ToList();
            return View(list);
        }

        [HttpPost]
        public JsonResult TestimonialDelete(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;

            if (user != null)
            {
                user.Status = false;
                var result =  _userManager.UpdateAsync(user).Result;
                if (result.Succeeded)
                {
                    return Json(result.Succeeded);
                }
            }

            return Json(user);
        }

        [HttpPost]
        public JsonResult TestimonialAdd(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;

            if (user != null)
            {
                user.Status = true;
                var result = _userManager.UpdateAsync(user).Result;
                if (result.Succeeded)
                {
                    return Json(result.Succeeded);
                }
            }

            return Json(user);
        }
    }
}

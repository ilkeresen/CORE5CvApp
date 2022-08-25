using Core5BlogApp.Areas.Admin.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Core5BlogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class WriterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public WriterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index(int page = 1, int pageSize = 6)
        {
            var list = _userManager.Users.Where(x => x.UserName != "admin").OrderByDescending(x=>x.Id).ToPagedList(page,pageSize);
            ViewBag.MainPageName = "Yazarlar";
            ViewBag.PageName = "Yazarlar Listesi";
            ViewData["WriterActive"] = "active";
            return View(list);
        }

        public IActionResult Profile(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            ViewBag.UserName = user.UserName;
            ViewBag.Name = user.Name;
            ViewBag.Surname = user.Surname;
            ViewBag.Email = user.Email;
            ViewBag.PhoneNumber = user.PhoneNumber;
            ViewBag.ImageUrl = user.ImageUrl;
            ViewBag.Job = user.Job;
            ViewBag.Content = user.Content;

            ViewBag.MainPageName = "Yazar Profil";
            ViewBag.PageName = "Yazar Profili";
            ViewData["WriterActive"] = "active";
            return View();
        }

        public IActionResult WriterProcess()
        {
            var list = _userManager.Users.Where(x => x.UserName != "admin").OrderByDescending(x => x.Id).ToList();
            ViewBag.MainPageName = "Yazar İşlemleri";
            ViewBag.PageName = "Yazar İşlemleri";
            ViewData["WriterProcessActive"] = "active";
            return View(list);
        }

        [HttpPost]
        public JsonResult WriterDelete(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            var backimageurl = user.ImageUrl;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\userimage", backimageurl);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _userManager.DeleteAsync(user);
            return Json(user);
        }

        [HttpPost]
        public JsonResult WriterGetItem(string id)
        {
            var user = JsonConvert.SerializeObject(_userManager.FindByIdAsync(id).Result);
            return Json(user);
        }

        [HttpPost]
        public JsonResult WriterUpdate(WriterEditViewModel writerEditViewModel, string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            user.UserName = writerEditViewModel.UserName;
            if (user.Status == false)
            {
                user.Status = false;
            }
            else if (user.Status == true)
            {
                user.Status = true;
            }
            else
            {
            }
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, writerEditViewModel.Password);
            var result = _userManager.UpdateAsync(user).Result;
            if (result.Succeeded)
            {
                return Json(result.Succeeded);
            }
            return Json(result);
        }
    }
}

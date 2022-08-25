using BusinessLayer.Concrete;
using Core5BlogApp.Areas.Writer.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize(Roles = "Writer")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewData["Name"] = result.Name;
            ViewData["SurName"] = result.Surname;
            ViewData["Email"] = result.Email;
            ViewData["ImageUrl"] = result.ImageUrl;

            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = result.Name;
            userEditViewModel.Surname = result.Surname;
            userEditViewModel.ImageUrl = result.ImageUrl;
            userEditViewModel.Job = result.Job;
            userEditViewModel.Content = result.Content;
            userEditViewModel.PhoneNumber = result.PhoneNumber;

            //statistics
            Context context = new Context();
            ViewBag.MessageCount = context.WriterMessages.Where(x => x.Receiver == result.Email && x.Status == true).Count();
            ViewBag.AnnouncementCount = context.Announcements.Count();
            ViewBag.UserCount = context.Users.Count();
            ViewBag.SkillCount = context.WriterMessages.Where(x => x.Sender == result.Email && x.Status == true).Count();

            ViewBag.MainPageName = "Profilim";
            ViewBag.PageName = "Profilim";
            ViewData["ProfileActive"] = "active";
            return View(userEditViewModel);
        }

        public PartialViewResult Profile()
        {
            return PartialView();
        }

        public PartialViewResult Settings()
        {
            return PartialView();
        }

        public async Task<JsonResult> SettingsUpdate(UserEditViewModel userEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userEditViewModel.Image != null)
            {
                var backimageurl = user.ImageUrl;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\userimage", backimageurl);

                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }

                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEditViewModel.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userimage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await userEditViewModel.Image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            user.Name = userEditViewModel.Name;
            user.Surname = userEditViewModel.Surname;
            user.PhoneNumber = userEditViewModel.PhoneNumber;
            user.Job = userEditViewModel.Job;
            user.Content = userEditViewModel.Content;
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
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                HttpContext.Session.SetString("Name", user.Name);
                HttpContext.Session.SetString("Surname", user.Surname);
                HttpContext.Session.SetString("ImageUrl", user.ImageUrl);
                return Json(result.Succeeded);
            }
            return Json(result);
        }
    }
}

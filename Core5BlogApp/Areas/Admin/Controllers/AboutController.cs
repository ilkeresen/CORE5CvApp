using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace Core5BlogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            ViewBag.MainPageName = "Hakkımda";
            ViewBag.PageName = "Hakkımda Listesi";
            ViewData["AboutActive"] = "active";
            var list = aboutManager.TGetList().First();
            ViewBag.İmage = "/images/" + list.AboutImageUrl;
            return View(list);
        }

        [HttpPost]
        public JsonResult AboutDelete(int id)
        {
            var about = aboutManager.TGetByID(id);

            if (about != null)
            {
                aboutManager.TDelete(about);
            }

            return Json(about);
        }

        [HttpPost]
        public JsonResult AboutAdd(About about)
        {
            if (about != null)
            {
                aboutManager.TAdd(about);
            }

            return Json(about);
        }

        [HttpPost]
        public JsonResult AboutGetItem(int id)
        {
            var about = JsonConvert.SerializeObject(aboutManager.TGetByID(id));
            return Json(about);
        }

        [HttpPost]
        public JsonResult AboutUpdate(About about, IFormFile AboutImageUrl)
        {
            var backimageurl = aboutManager.TGetByID(about.AboutID);
            var url = backimageurl.AboutImageUrl;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", url);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            var resoruce = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(AboutImageUrl.FileName);
            var imagename = Guid.NewGuid() + extension;
            var sacelocation = resoruce + "/wwwroot/images/" + imagename;
            var stream = new FileStream(sacelocation, FileMode.Create);
            AboutImageUrl.CopyToAsync(stream);
            about.AboutImageUrl = imagename;

            

            aboutManager.TUpdate(about);

            return Json(about);
        }
    }
}

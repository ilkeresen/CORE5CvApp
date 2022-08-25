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
    public class ContactMessageController : Controller
    {
        ContactMessageManager contactMessageManager = new ContactMessageManager(new EfContactMessageRepository());
        public IActionResult Index()
        {
            ViewBag.MainPageName = "İletişim Mesajları";
            ViewBag.PageName = "İletişim Mesajları";
            ViewData["ContactMessageActive"] = "active";
            var list = contactMessageManager.TGetList();
            return View(list);
        }

        [HttpPost]
        public JsonResult ContactMessageDelete(int id)
        {
            var contactMessage = contactMessageManager.TGetByID(id);

            if (contactMessage != null)
            {
                contactMessageManager.TDelete(contactMessage);
            }

            return Json(contactMessage);
        }

        [HttpPost]
        public JsonResult ContactMessageGetItem(int id)
        {
            var contactMessage = JsonConvert.SerializeObject(contactMessageManager.TGetByID(id));
            return Json(contactMessage);
        }

        [HttpPost]
        public JsonResult ContactMessageUpdate(int id)
        {
            var contactMessage = contactMessageManager.TGetByID(id);

            if (contactMessage != null)
            {
                contactMessage.ContactMessageApproval = true;
                contactMessageManager.TUpdate(contactMessage);
            }

            return Json(contactMessage);
        }
    }
}

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
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactRepository());
        public IActionResult Index()
        {
            ViewBag.MainPageName = "İletişim";
            ViewBag.PageName = "İletişim Listesi";
            ViewData["ContactActive"] = "active";
            var list = contactManager.TGetList();
            return View(list);
        }

        [HttpPost]
        public JsonResult ContactDelete(int id)
        {
            var contact = contactManager.TGetByID(id);

            if (contact != null)
            {
                contactManager.TDelete(contact);
            }

            return Json(contact);
        }

        [HttpPost]
        public JsonResult ContactAdd(Contact contact)
        {
            if (contact != null)
            {
                contactManager.TAdd(contact);
            }

            return Json(contact);
        }

        [HttpPost]
        public JsonResult ContactGetItem(int id)
        {
            var contact = JsonConvert.SerializeObject(contactManager.TGetByID(id));
            return Json(contact);
        }

        [HttpPost]
        public JsonResult ContactUpdate(Contact contact)
        {
            if (contact != null)
            {
                contactManager.TUpdate(contact);
            }

            return Json(contact);
        }
    }
}

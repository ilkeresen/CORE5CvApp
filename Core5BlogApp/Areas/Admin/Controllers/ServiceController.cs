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
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceRepository());
        public IActionResult Index()
        {
            ViewBag.MainPageName = "Hizmetlerim";
            ViewBag.PageName = "Hizmetlerim Listesi";
            ViewData["ServiceActive"] = "active";
            var list = serviceManager.TGetList();
            return View(list);
        }

        [HttpPost]
        public JsonResult ServiceDelete(int id)
        {
            var service = serviceManager.TGetByID(id);

            if (service != null)
            {
                serviceManager.TDelete(service);
            }

            return Json(service);
        }

        [HttpPost]
        public JsonResult ServiceAdd(Service service)
        {
            if (service != null)
            {
                serviceManager.TAdd(service);
            }

            return Json(service);
        }

        [HttpPost]
        public JsonResult ServiceGetItem(int id)
        {
            var service = JsonConvert.SerializeObject(serviceManager.TGetByID(id));
            return Json(service);
        }

        [HttpPost]
        public JsonResult ServiceUpdate(Service service)
        {
            if (service != null)
            {
                serviceManager.TUpdate(service);
            }

            return Json(service);
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.WriterProfile
{
    public class WriterLayoutNotificationList : ViewComponent
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementRepository());
        public IViewComponentResult Invoke() 
        {
            var list = announcementManager.TGetList().OrderByDescending(x => x.Id).Take(3).ToList();
            ViewBag.Count = announcementManager.TGetList().TakeLast(3).Count();
            return View(list);
        }
    }
}

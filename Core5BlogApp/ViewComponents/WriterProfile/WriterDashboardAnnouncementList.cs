using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.WriterProfile
{
    public class WriterProfileAnnouncementList : ViewComponent
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementRepository());

        public IViewComponentResult Invoke()
        {
            var list = announcementManager.TGetList();
            return View(list);
        }
    }
}

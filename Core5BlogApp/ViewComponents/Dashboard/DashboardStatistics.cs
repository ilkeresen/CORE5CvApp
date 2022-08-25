using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.Dashboard
{
    public class DashboardStatistics : ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillRepository());
        ContactMessageManager contactMessageManager = new ContactMessageManager(new EfContactMessageRepository());
        ResumeManager resumeManager = new ResumeManager(new EfResumeRepository());

        public IViewComponentResult Invoke()
        {
            ViewBag.SkillCount = skillManager.TGetList().Count();
            ViewBag.MessageNoRead = contactMessageManager.TGetList().Where(x => x.ContactMessageApproval == false).Count();
            ViewBag.MessageYesRead = contactMessageManager.TGetList().Where(x => x.ContactMessageApproval == true).Count();
            ViewBag.ResumeCount = resumeManager.TGetList().Count();
            return View();
        }

    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.Resume
{
    public class ResumeList : ViewComponent
    {
        ResumeManager resumeManager = new ResumeManager(new EfResumeRepository());

        public IViewComponentResult Invoke()
        {
            var list = resumeManager.TGetList();
            return View(list);
        }
    }
}

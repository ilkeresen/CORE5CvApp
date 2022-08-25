using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.SocialMedia
{
    public class SocialMediaList : ViewComponent
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaRepository());

        public IViewComponentResult Invoke()
        {
            var list = socialMediaManager.TGetList().Where(x=>x.SocialMediaStatus == true).ToList();
            return View(list);
        }
    }
}

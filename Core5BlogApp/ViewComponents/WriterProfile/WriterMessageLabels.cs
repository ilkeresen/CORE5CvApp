using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.WriterProfile
{
    public class WriterMessageLabels : ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageRepository());

        public WriterMessageLabels(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var filter = values.Email;
            var ImportantMessage = writerMessageManager.TGetList().Count(x => x.Receiver == filter && x.Status == true && x.Label == "Important" || x.Sender == filter && x.Status == true && x.Label == "Important").ToString();
            ViewBag.ImportantMessage = ImportantMessage;
            var PromotionsMessage = writerMessageManager.TGetList().Count(x => x.Receiver == filter && x.Status == true && x.Label == "Promotions" || x.Sender == filter && x.Status == true && x.Label == "Promotions").ToString();
            ViewBag.PromotionsMessage = PromotionsMessage;
            var SocialMessage = writerMessageManager.TGetList().Count(x => x.Receiver == filter && x.Status == true && x.Label == "Social" || x.Sender == filter && x.Status == true && x.Label == "Social").ToString();
            ViewBag.SocialMessage = SocialMessage;
            var NoMessage = writerMessageManager.TGetList().Count(x => x.Receiver == filter && x.Status == true && x.Label == null || x.Sender == filter && x.Status == true && x.Label == null).ToString();
            ViewBag.NoMessage = NoMessage;
            return View();
        }
    }
}

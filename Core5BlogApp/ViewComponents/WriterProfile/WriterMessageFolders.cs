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
    public class WriterMessageFolders : ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageRepository());

        public WriterMessageFolders(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var filter = values.Email;
            var ReceiverMessage = writerMessageManager.TGetList().Count(x => x.Receiver == filter && x.Status == true).ToString();
            ViewBag.ReceiverMessage = ReceiverMessage;
            var SenderMessage = writerMessageManager.TGetList().Count(x => x.Sender == filter && x.Status == true).ToString();
            ViewBag.SenderMessage = SenderMessage;
            var TrashMessage = writerMessageManager.TGetList().Count(x => x.Sender == filter && x.Status == false || x.Receiver == filter && x.Status == false).ToString();
            ViewBag.TrashMessage = TrashMessage;
            return View();
        }
    }
}

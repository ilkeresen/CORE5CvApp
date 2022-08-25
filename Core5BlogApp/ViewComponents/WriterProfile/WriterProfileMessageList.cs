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
    public class WriterProfileMessageList : ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageRepository());
        private readonly UserManager<WriterUser> _userManager;

        public WriterProfileMessageList(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke(string filter)
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name).Result;
            filter = values.Email;
            var messageList = writerMessageManager.GetListReceiverMessage(filter);
            return View(messageList);
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize(Roles = "Writer")]
    public class MessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageRepository());
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> ReceiverMessage(string filter)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            filter = values.Email;
            var messageList = writerMessageManager.GetListReceiverMessage(filter);

            ViewBag.MainPageName = "Gelen Kutusu";
            ViewBag.PageName = "Gelen Kutusu";
            ViewData["MessageActive"] = "active";
            return View(messageList);
        }

        public async Task<IActionResult> SenderMessage(string filter)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            filter = values.Email;
            var messageList = writerMessageManager.GetListSenderMessage(filter);

            ViewBag.MainPageName = "Giden Kutusu";
            ViewBag.PageName = "Giden Kutusu";
            ViewData["MessageActive"] = "active";
            return View(messageList);
        }

        public async Task<IActionResult> TrashMessage(string filter)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            filter = values.Email;
            var messageList = writerMessageManager.GetListTrashMessage(filter);

            ViewBag.MainPageName = "Çöp Kutusu";
            ViewBag.PageName = "Çöp Kutusu";
            ViewData["MessageActive"] = "active";
            return View(messageList);
        }

        public IActionResult MessageDetails(int id)
        {
            ViewBag.MainPageName = "Mesaj Detay";
            ViewBag.PageName = "Mesaj Detay";
            ViewData["MessageActive"] = "active";
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            return View(writerMessage);
        }

        public IActionResult DeleteMessage(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            writerMessageManager.TDelete(writerMessage);
            return RedirectToAction("SenderMessage", "Message");
        }
        
        public IActionResult NotDeleteMessage(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            writerMessage.Status = true;
            writerMessageManager.TUpdate(writerMessage);
            return RedirectToAction("SenderMessage", "Message");
        }

        public IActionResult MessageTrash(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            writerMessage.Status = false;
            writerMessageManager.TUpdate(writerMessage);
            return RedirectToAction("SenderMessage", "Message");
        }

        [HttpGet]
        public IActionResult AddMessage()
        {
            ViewBag.MainPageName = "Yeni Mesaj Gönder";
            ViewBag.PageName = "Yeni Mesaj Gönder";
            ViewData["MessageActive"] = "active";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMessage(WriterMessage writerMessage)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            writerMessage.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            writerMessage.Sender = mail;
            writerMessage.SenderName = name;
            writerMessage.Status = true;
            Context context = new Context();
            var receivernamesurname = context.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writerMessage.ReceiverName = receivernamesurname;
            writerMessageManager.TAdd(writerMessage);
            return RedirectToAction("SenderMessage","Message");
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageRepository());
        public IActionResult ReceiverMessage()
        {
            var filter = "admin@gmail.com";
            var messageList = writerMessageManager.GetListReceiverMessage(filter);
            ViewBag.MainPageName = "Gelen Kutusu";
            ViewBag.PageName = "Gelen Kutusu";
            ViewData["AdminMessageActive"] = "active";
            return View(messageList);
        }

        public IActionResult SenderMessage()
        {
            var filter = "admin@gmail.com";
            var messageList = writerMessageManager.GetListSenderMessage(filter);
            ViewBag.MainPageName = "Giden Kutusu";
            ViewBag.PageName = "Giden Kutusu";
            ViewData["AdminMessageActive"] = "active";
            return View(messageList);
        }

        public IActionResult TrashMessage(string filter = "admin@gmail.com")
        {
            var messageList = writerMessageManager.GetListTrashMessage(filter);

            ViewBag.MainPageName = "Çöp Kutusu";
            ViewBag.PageName = "Çöp Kutusu";
            ViewData["MessageActive"] = "active";
            return View(messageList);
        }

        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            return View(writerMessage);
        }

        public IActionResult DeleteMessage(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            writerMessageManager.TDelete(writerMessage);
            return RedirectToAction("SenderMessage", "AdminMessage");
        }

        public IActionResult NotDeleteMessage(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            writerMessage.Status = true;
            writerMessageManager.TUpdate(writerMessage);
            return RedirectToAction("SenderMessage", "AdminMessage");
        }

        public IActionResult MessageTrash(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            writerMessage.Status = false;
            writerMessageManager.TUpdate(writerMessage);
            return RedirectToAction("SenderMessage", "AdminMessage");
        }

        [HttpGet]
        public IActionResult AddMessage()
        {
            ViewBag.MainPageName = "Yeni Mesaj Gönder";
            ViewBag.PageName = "Yeni Mesaj Gönder";
            ViewData["AdminMessageActive"] = "active";
            return View();
        }

        [HttpPost]
        public IActionResult AddMessage(WriterMessage writerMessage)
        {
            writerMessage.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            writerMessage.Sender = "admin@gmail.com";
            writerMessage.SenderName = "Admin";
            writerMessage.Status = true;
            Context context = new Context();
            var receivernamesurname = context.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writerMessage.ReceiverName = receivernamesurname;
            writerMessageManager.TAdd(writerMessage);
            return RedirectToAction("SenderMessage", "AdminMessage");
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.Areas.ShowCase.Controllers
{
    [Area("ShowCase")]
    [AllowAnonymous]
    public class ShowCaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HtmlHeadTag()
        {
            return PartialView();
        }
        
        public PartialViewResult Footer()
        {
            return PartialView();
        }

        public PartialViewResult Scripts()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult ContactMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult ContactMessage(ContactMessage contactMessage)
        {
            ContactMessageManager contactMessageManager = new ContactMessageManager(new EfContactMessageRepository());

            contactMessage.ContactMessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            contactMessage.ContactMessageApproval = true;
            contactMessage.ContactMessageStatus = true;
            contactMessageManager.TAdd(contactMessage);
            return PartialView();
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.Contact
{
    public class ContactMessage : ViewComponent
    {
        ContactMessageManager contactMessageManager = new ContactMessageManager(new EfContactMessageRepository());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(EntityLayer.Concrete.ContactMessage contactMessage)
        //{
        //    contactMessage.ContactMessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    contactMessage.ContactMessageApproval = true;
        //    contactMessage.ContactMessageStatus = true;
        //    contactMessageManager.TAdd(contactMessage);
        //    return View();
        //}
    }
}

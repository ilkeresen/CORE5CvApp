using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.Contact
{
    public class ContactList : ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EfContactRepository());
        public IViewComponentResult Invoke()
        {
            var list = contactManager.TGetList();
            return View(list);
        }
    }
}

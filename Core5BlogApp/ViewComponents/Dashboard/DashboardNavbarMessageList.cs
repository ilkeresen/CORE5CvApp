using Core5BlogApp.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.Dashboard
{
    public class DashboardNavbarMessageList : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var filter = "admin@gmail.com";
            var list = (from x in context.Users
                       join y in context.WriterMessages
                       on x.Email equals y.Sender
                       where y.Receiver == filter && y.Status == true
                       select new WriterMessageImageUrl
                       {
                           ImageUrl = x.ImageUrl,
                           Date = y.Date,
                           SenderName = y.SenderName,
                           MessageContent = y.MessageContent,
                           Id= y.Id
                       }).OrderByDescending(x=>x.Id).Take(3).ToList();
            return View(list);
        }
    }
}

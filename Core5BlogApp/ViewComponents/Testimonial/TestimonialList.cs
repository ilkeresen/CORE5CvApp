using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var list = context.Users.Where(x => x.Job != null && x.Content != null && x.Status == true).ToList();
            return View(list);
        }
    }
}

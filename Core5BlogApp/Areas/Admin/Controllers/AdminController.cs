using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        public PartialViewResult LeftBar()
        {
            return PartialView();
        }

        public PartialViewResult TopBar()
        {
            return PartialView();
        }

        public PartialViewResult Footer()
        {
            return PartialView();
        }

        public PartialViewResult HtmlHeadTag()
        {
            return PartialView();
        }

        public PartialViewResult HtmlScriptTag()
        {
            return PartialView();
        }

        public PartialViewResult PageTopNavigation()
        {
            return PartialView();
        }
    }
}

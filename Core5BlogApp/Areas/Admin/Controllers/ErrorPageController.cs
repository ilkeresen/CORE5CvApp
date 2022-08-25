using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ErrorPageController : Controller
    {
        public IActionResult ErrorPage401()
        {
            return View();
        }
        
        public IActionResult ErrorPage404()
        {
            return View();
        }
    }
}

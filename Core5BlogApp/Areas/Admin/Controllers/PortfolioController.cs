using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioRepository());
        public IActionResult Index()
        {
            ViewBag.MainPageName = "Referanslarım";
            ViewBag.PageName = "Referanslarım Listesi";
            ViewData["PortfolioActive"] = "active";
            var list = portfolioManager.TGetList();
            return View(list);
        }

        [HttpPost]
        public JsonResult PortfolioDelete(int id)
        {
            var portfolio = portfolioManager.TGetByID(id);
            var url = portfolio.PortfolioImageUrl;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\portfolio", url);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            portfolioManager.TDelete(portfolio);
            return Json(portfolio);
        }

        [HttpPost]
        public JsonResult PortfolioAdd(Portfolio portfolio, IFormFile PortfolioImageUrl)
        {
            var resoruce = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(PortfolioImageUrl.FileName);
            var imagename = Guid.NewGuid() + extension;
            var sacelocation = resoruce + "/wwwroot/images/portfolio/" + imagename;
            var stream = new FileStream(sacelocation, FileMode.Create);
            PortfolioImageUrl.CopyToAsync(stream);
            portfolio.PortfolioImageUrl = imagename;
            portfolioManager.TAdd(portfolio);
            return Json(portfolio);
        }

        [HttpPost]
        public JsonResult PortfolioGetItem(int id)
        {
            var portfolio = JsonConvert.SerializeObject(portfolioManager.TGetByID(id));
            return Json(portfolio);
        }

        [HttpPost]
        public JsonResult PortfolioUpdate(Portfolio portfolio, IFormFile PortfolioImageUrl)
        {
            var backimageurl = portfolioManager.TGetByID(portfolio.PortfolioID);
            var url = backimageurl.PortfolioImageUrl;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\portfolio", url);

            if (PortfolioImageUrl == null)
            {
                portfolio.PortfolioImageUrl = url;
                portfolioManager.TUpdate(portfolio);
            }
            else if (PortfolioImageUrl != null)
            {
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }

                var resoruce = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(PortfolioImageUrl.FileName);
                var imagename = Guid.NewGuid() + extension;
                var sacelocation = resoruce + "/wwwroot/images/portfolio/" + imagename;
                var stream = new FileStream(sacelocation, FileMode.Create);
                PortfolioImageUrl.CopyToAsync(stream);
                portfolio.PortfolioImageUrl = imagename;
                portfolioManager.TUpdate(portfolio);
            }
            return Json(portfolio);
        }
    }
}

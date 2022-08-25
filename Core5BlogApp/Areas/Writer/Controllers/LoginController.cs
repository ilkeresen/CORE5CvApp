using Core5BlogApp.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.Areas.Writer.Controllers
{
    [Area("Writer")]
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInManager;
        private readonly UserManager<WriterUser> _userManager;

        public LoginController(SignInManager<WriterUser> signInManager, UserManager<WriterUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel userLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(userLoginViewModel.UserName, userLoginViewModel.Password, userLoginViewModel.Remember, true);
                if (result.Succeeded)
                {
                    if (userLoginViewModel.UserName == "admin")
                    {
                        var user = await _userManager.FindByNameAsync(userLoginViewModel.UserName);
                        HttpContext.Session.SetString("Name", user.Name);
                        HttpContext.Session.SetString("Mail", user.Email);
                        HttpContext.Session.SetString("Surname", user.Surname);
                        HttpContext.Session.SetString("ImageUrl", user.ImageUrl);
                        return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                    }
                    else
                    {
                        var user = await _userManager.FindByNameAsync(userLoginViewModel.UserName);
                        HttpContext.Session.SetString("Name", user.Name);
                        HttpContext.Session.SetString("Mail", user.Email);
                        HttpContext.Session.SetString("Surname", user.Surname);
                        HttpContext.Session.SetString("ImageUrl", user.ImageUrl);
                        return RedirectToAction("Index", "Dashboard");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre girdiniz.");
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
//Sifre
//123456Aa-
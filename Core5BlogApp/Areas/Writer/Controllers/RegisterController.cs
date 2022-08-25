using Core5BlogApp.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
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
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel userRegisterViewModel)
        {
            if (ModelState.IsValid)
            {
                WriterUser writerUser = new WriterUser()
                {
                    Name = userRegisterViewModel.Name,
                    Surname = userRegisterViewModel.Surname,
                    Email = userRegisterViewModel.Mail,
                    UserName = userRegisterViewModel.UserName,
                    ImageUrl = userRegisterViewModel.ImageUrl
                };

                if (userRegisterViewModel.Password == userRegisterViewModel.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(writerUser, userRegisterViewModel.Password);

                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(writerUser, "WRITER");
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, item.Description);
                        }
                    }
                }
            }
            return View();
        }
    }
}

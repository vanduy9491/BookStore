using BookStore.Entities;
using BookStore.Models.Account;
using BookStore.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppIdentityUser> userManager;
        private readonly SignInManager<AppIdentityUser> signInManager;

        //private readonly IUserService userService;

        //public AccountController(IUserService userService)
        //{
        //    this.userService = userService;
        //}
        public AccountController(UserManager<AppIdentityUser> userManager,
                                SignInManager<AppIdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            //if (ModelState.IsValid)
            //{
            //    var result = await userService.Login(login);
            //    if (result.Success)
            //    {
            //        return RedirectToAction("Index", "Dashboard");
            //    }
            //    ViewBag.Error = result.Message;
            //    return View();
            //}
            //return View();
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(login.Email);
                if (user == null)
                {
                    ViewBag.Error = "User is existing";
                    return View();
                }
                var signInResult = await signInManager.PasswordSignInAsync(user, login.Password, login.RememberMe, false);
                if (signInResult.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
            }
            ViewBag.Error = "Something went wrong, please try again later.";
            return View();
        }
    }
}

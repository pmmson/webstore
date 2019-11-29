using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DomainNew.Entities;
using WebStore.Models.Account;

namespace WebStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterUserViewModel());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { UserName = model.UserName }; //создаем сущность пользователь
                var createResult = await _userManager.CreateAsync(user, model.Password); //используем менеджер для создания

                if (createResult.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false); //если успешно - производим логин
                    RedirectToAction("Index", "Home");
                }
                else //иначе
                {
                    foreach (var identityError in createResult.Errors) //выводим ошибки
                    {
                        ModelState.AddModelError("", identityError.Description);
                    }
                }
            }
            return View(model);
        }
    }
}

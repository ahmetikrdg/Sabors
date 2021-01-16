using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sabor.EmailServices;
using Sabor.Identity;
using Sabor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sabor.Controllers
{
    public class AccountController:Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _SignInManager;
        private IEmailSender _emailSender;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender )
        {
            _SignInManager = signInManager;
            _userManager = userManager;
            _emailSender = emailSender;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);     
            }
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user==null)
            {
               ModelState.AddModelError("","Girdiğiniz kullanıcı adı ile daha önce hesap oluşturulmadı. Tekrar Deneyiniz!!!");
                return View(model);
            }
            //BURASI KULLANICI EMAİLİ ONAYLAMADIYSA ALANI-----------
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Henüz hesabınızı onaylamadınız. Lütfen email adresinizden hesabınızı onaylayınız!!!");
                return View(model);
            }
            //------------------------------------------------------
            var result = await _SignInManager.PasswordSignInAsync(user, model.Password,true,true);//true kullanıcı tarayıcıyı kapayınca cookie silinmesin benim belirrtiğim zamana kadar kalsın startupta belirttim.. true ise 5 hatalı deneme sonrası hesap kitlenmesi aktif.
            if (result.Succeeded)
            {
                return RedirectToAction("ProductList", "Admin");
            }
            ModelState.AddModelError("", "Parola Yanlış!!! Tekrar deneyiniz.");
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//csrf ataklarını engellemek için.Getle sayfadan gelen token bilgisi postta gelmiyosa işlemi gerçekleştirmes cross side ataklarının önüne geçer
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };
            var result = await _userManager.CreateAsync(user,model.Password);
            if (result.Succeeded)
            {
                //generate token hesap onayı için -------------------------
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);//user bilgisiyle token oluşturdum
                var url = Url.Action("ConfirmEmail", "Account", new//confirmemail adresine gideceğiz
                {
                    UserId=user.Id,
                    token=code
                });//bize bir url oluşturdu -------------------------------
                //email gönderme işlemi hesap onayı için ------------------------------------
                await _emailSender.SendEmailAsync(model.Email,"Hesabınızı onaylayınız",$"Lütfen email hesabınızı onaylamak için <a href='https://localhost:44306{url}'> tıklayınız. </a>");
               //------------------------------------
                return RedirectToAction("Login", "Account");        
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _SignInManager.SignOutAsync();
            return Redirect("~/");//anasayfaya
        }

        public async Task<IActionResult> ConfirmEmail(string userId,string token) //email onayı 
        {
            if (userId==null||token==null)
            {
                
            }
            var user = await _userManager.FindByIdAsync(userId);
            var result = await _userManager.ConfirmEmailAsync(user,token);//userle tokeni eşleştirir buna göre hesap alanını true yapar
           
            return View();
        }
    }
}
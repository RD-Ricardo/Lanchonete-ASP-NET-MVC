using Lanchonete_ASP_NET_MVC.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lanchonete_ASP_NET_MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login(string returnUrl)
        {
            return View(
                new LoginViewModel(){
                    ReturnUrl = returnUrl
                }
            );
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginView)
        {
           if(!ModelState.IsValid)
                return View(loginView);

            var user = await _userManager.FindByNameAsync(loginView.UserName);

            if(user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginView.Password, false,false);
                if(result.Succeeded)
                {
                    if(string.IsNullOrEmpty(loginView.ReturnUrl))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    return Redirect(loginView.ReturnUrl);
                }
            }
            ModelState.AddModelError("", "Falaha ao realizar o login!!");
            return View(loginView);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LoginViewModel registerVm)
        {
            if(ModelState.IsValid){
                var user  = new IdentityUser {UserName = registerVm.UserName,};

                var result = await _userManager.CreateAsync(user, registerVm.Password);
                if(result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    this.ModelState.AddModelError("Registro", "Falha ao registar");
                }
            }
            return View(registerVm);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.User = null;
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
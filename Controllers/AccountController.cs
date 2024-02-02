using DwitterLoungeBar.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DwitterLoungeBar.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel() { ReturnUrl = returnUrl});
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
                return View(loginViewModel);

            var user = await userManager.FindByNameAsync(loginViewModel.UserName);  

            if(user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);

                if(result.Succeeded)
                {
                    if(string.IsNullOrEmpty(loginViewModel.ReturnUrl))
                       return RedirectToAction ("Index", "Home");

                    return Redirect(loginViewModel.ReturnUrl);  
                }
            }

            ModelState.AddModelError("", "Username or password not correct");
            return View(loginViewModel);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid) return View(loginViewModel);

            var user = await userManager.FindByNameAsync(loginViewModel.UserName);

            if(user != null)
            {
                ModelState.AddModelError("", "This username is already in use");
                return View(loginViewModel);
            }

            var newUser = new IdentityUser
            {
                UserName = loginViewModel.UserName
            };

            var result = await userManager.CreateAsync(newUser, loginViewModel.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(loginViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync(); 
            return RedirectToAction("Index", "Home");   
        }
    }
}

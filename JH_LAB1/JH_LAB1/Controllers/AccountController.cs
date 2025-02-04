using JH_LAB1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JH_LAB1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /*
        private UserManager<AppUsers> userManager;
        private SignInManager<AppUsers> signInManager;
        public AccountController(UserManager<AppUsers> userManager,
                                    SignInManager<AppUsers> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string returnUrl)
        {
            Login login = new Login();
            login.ReturnUrl = returnUrl;
            return View(login);
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                AppUsers users = await userManager.FindByEmailAsync(login.Email);
                if (users != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.
                        PasswordSignInAsync(users, login.Password, false, false);

                    if (result.Succeeded)
                    {
                        return Redirect(login.ReturnUrl ?? "/");
                    }

                }
                ModelState.AddModelError(nameof(login.Email), "Login Failed: Due to Useremail or password Incorrect");

            }
            return View(login);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
        */
    }
}

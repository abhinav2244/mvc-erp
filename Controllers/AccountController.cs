using Microsoft.AspNetCore.Mvc;
using mvc_erp.Models;
using mvc_erp.Services;

namespace mvc_erp.Controllers
{
    public class AccountController : Controller
    {

        private readonly LoginService _loginService;

        // LoginService DI ke through controller mein aayegi
        public AccountController(LoginService loginService)
        {
            _loginService = loginService;
        }

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> Login(LoginViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }   

            // Database se username ke basis par user nikalega
            var users = await _loginService.GetLoginUserAsync(model.Username);

            if (users == null || users.Count == 0)
            {
                ModelState.AddModelError("", "User Id or Password is Wrong.");
                return View(model);
            }
            // User was found successfully 
            var user = users.First();

             // Temporary success message for testing
             ViewBag.LoginMessage = "Login Successful!";

            // Yahan existing decryption project baad mein use hoga.
            // Abhi decryption ko touch nahi kar rahe hain.

            // Login authentication will be added in the next steps.
            return View(model);
        }
    }
}

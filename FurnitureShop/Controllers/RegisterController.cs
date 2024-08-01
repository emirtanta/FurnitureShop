using FurnitureShop.Entities;
using FurnitureShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterVM model)
        {
            if (!ModelState.IsValid) 
            {
                return View(model);
            }

            var user = new AppUser
            {
                Email = model.Email,
                UserName = model.Username,
                Name = model.Name,
                Surname = model.Surname
            };

            var result=await _userManager.CreateAsync(user,model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(string.Empty, item.Description);
            }

            return View(model);
        }
    }
}

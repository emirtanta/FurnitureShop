using FurnitureShop.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Areas.Admin.ViewComponents
{
    public class _AdminNavbarLayoutComponent:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _AdminNavbarLayoutComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.Name = user.Name;
            ViewBag.ImageUrl=user.ImageUrl;

            return View();
        }
    }
}

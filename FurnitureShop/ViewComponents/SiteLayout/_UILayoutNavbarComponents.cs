using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.ViewComponents.SiteLayout
{
    public class _UILayoutNavbarComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

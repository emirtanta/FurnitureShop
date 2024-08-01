using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.ViewComponents.SiteLayout
{
    public class _UILayoutHeadComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

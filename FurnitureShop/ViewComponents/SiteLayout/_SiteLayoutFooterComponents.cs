using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.ViewComponents.SiteLayout
{
    public class _SiteLayoutFooterComponents:ViewComponent
    {
        private readonly FurnitureContext _context;

        public _SiteLayoutFooterComponents(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.SocialMedias.ToList();

            return View(values);
        }
    }
}

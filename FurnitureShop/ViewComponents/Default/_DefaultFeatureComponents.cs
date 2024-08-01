using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.ViewComponents.Default
{
    public class _DefaultFeatureComponents:ViewComponent
    {
        private readonly FurnitureContext _context;

        public _DefaultFeatureComponents(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Features.ToList();

            return View(); 
        }
    }
}

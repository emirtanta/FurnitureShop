using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.ViewComponents.Default
{
    public class _DefaultServiceComponents:ViewComponent
    {
        private readonly FurnitureContext _context;

        public _DefaultServiceComponents(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Services.ToList();

            return View(values);
        }
    }
}

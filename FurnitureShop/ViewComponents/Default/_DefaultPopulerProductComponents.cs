using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.ViewComponents.Default
{
    public class _DefaultPopulerProductComponents:ViewComponent
    {
        private readonly FurnitureContext _context;

        public _DefaultPopulerProductComponents(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var latestProducts=_context.Products
                .OrderByDescending(x=>x.ProductId)
                .Take(3)
                .ToList();

            return View(latestProducts);
        }
    }
}

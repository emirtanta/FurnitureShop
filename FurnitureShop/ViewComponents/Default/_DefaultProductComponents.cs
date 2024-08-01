using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.ViewComponents.Default
{
    public class _DefaultProductComponents:ViewComponent
    {

        private readonly FurnitureContext _context;

        public _DefaultProductComponents(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values=_context.Products.OrderByDescending(x=>x.ProductId).Take(3).ToList();

            return View(values);
        }
    }
}

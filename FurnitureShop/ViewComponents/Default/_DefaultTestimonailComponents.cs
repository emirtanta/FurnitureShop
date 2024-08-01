using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.ViewComponents.Default
{
    public class _DefaultTestimonailComponents:ViewComponent
    {
        private readonly FurnitureContext _context;

        public _DefaultTestimonailComponents(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }
    }
}

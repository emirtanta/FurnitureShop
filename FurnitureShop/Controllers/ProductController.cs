using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly FurnitureContext _context;

        public ProductController(FurnitureContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result=_context.Products.ToList();
            return View(result);
        }
    }
}

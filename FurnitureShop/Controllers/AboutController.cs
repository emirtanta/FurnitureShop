using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

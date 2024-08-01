using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

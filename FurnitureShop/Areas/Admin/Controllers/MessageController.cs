
using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class MessageController : Controller
    {
        private readonly FurnitureContext _context;

        public MessageController(FurnitureContext context)
        {
            _context = context;
        }

        public IActionResult MessageList()
        {
            var result = _context.UserMessages.ToList();

            return View(result);
        }
    }
}

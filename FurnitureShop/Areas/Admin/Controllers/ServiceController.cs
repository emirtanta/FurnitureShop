using FurnitureShop.Entities;
using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ServiceController : Controller
    {
        private readonly FurnitureContext _context;

        public ServiceController(FurnitureContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Services.ToList();

            return View(result);
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Add(service);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }

            return View(service);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var service=_context.Services.FindAsync(id);

            if (service==null)
            {
                return NotFound();
            }

            return View(service);

        }

        [HttpPost]
        public async Task<IActionResult> UpdateService(Service service)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Services.Update(service);

                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {

                    ModelState.AddModelError("", "Lütfen tekrar deneyin");
                }
            }

            return View(service);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteService(int id)
        {
            var service=await _context.Services.FindAsync(id);

            if (service==null)
            {
                return NotFound();
            }

            _context.Services.Remove(service);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}

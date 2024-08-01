using FurnitureShop.Entities;
using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class FeatureController : Controller
    {
        private readonly FurnitureContext _context;

        public FeatureController(FurnitureContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result=_context.Features.ToList();

            return View(result);
        }

        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(Feature feature)
        {
            if (ModelState.IsValid)
            {
                _context.Features.Add(feature);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(feature);
        }

        public async Task<IActionResult> UpdateFeature(int id)
        {
            var feature=await _context.Features.FindAsync(id);

            if (feature==null)
            {
                return NotFound();
            }

            return View(feature);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateFeature(Feature feature)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Features.Update(feature);

                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Lütfen Tekrar Deneyiniz.");
                }
            }
            return View(feature);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            var result = await _context.Features.FindAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            _context.Features.Remove(result);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}

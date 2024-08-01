using FurnitureShop.Entities;
using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Areas.Admin.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly FurnitureContext _context;

        public SocialMediaController(FurnitureContext context)
        {
            _context = context;
        }

        public  IActionResult Index()
        {
            var result =  _context.SocialMedias.ToList();

            return View(result);
        }

        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSocialMedia(SocialMedia socialMedia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(socialMedia);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(socialMedia);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSocialMedia(int id)
        {
            var socialMedia = await _context.Products.FindAsync(id);

            if (socialMedia == null)
            {
                return NotFound();
            }

            return View(socialMedia);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateSocialMedia(SocialMedia socialMedia)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.SocialMedias.Update(socialMedia);

                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {

                    ModelState.AddModelError("", "Lütfen tekrar deneyiniz!");
                }
            }
            return View(socialMedia);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteSocialMedia(int id)
        {
            var socialMedia = await _context.SocialMedias.FindAsync(id);

            if (socialMedia == null)
            {
                return NotFound();
            }

            _context.SocialMedias.Remove(socialMedia);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}

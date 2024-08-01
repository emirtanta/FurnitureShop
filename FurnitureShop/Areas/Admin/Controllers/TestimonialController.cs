using FurnitureShop.Entities;
using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class TestimonialController : Controller
    {
        private readonly FurnitureContext _context;

        public TestimonialController(FurnitureContext context)
        {
            _context = context;
        }

        public  IActionResult Index()
        {
            var result =  _context.Testimonials.ToList();

            return View(result);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(Testimonial testimonial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testimonial);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(testimonial);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var testimonial = await _context.Testimonials.FindAsync(id);

            if (testimonial == null)
            {
                return NotFound();
            }

            return View(testimonial);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateTestimonial(Testimonial testimonial)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Testimonials.Update(testimonial);

                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {

                    ModelState.AddModelError("", "Lütfen tekrar deneyiniz!");
                }
            }
            return View(testimonial);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var testimonial = await _context.Testimonials.FindAsync(id);

            if (testimonial == null)
            {
                return NotFound();
            }

            _context.Testimonials.Remove(testimonial);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}

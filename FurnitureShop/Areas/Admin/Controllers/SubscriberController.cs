using FurnitureShop.Entities;
using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Areas.Admin.Controllers
{
    public class SubscriberController : Controller
    {
        private readonly FurnitureContext _context;

        public SubscriberController(FurnitureContext context)
        {
            _context = context;
        }

        public  IActionResult Index()
        {
            var result =  _context.Subscribers.ToList();

            return View(result);
        }

        [HttpGet]
        public IActionResult CreateSubscriber()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubscriber(Subscriber subscriber)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subscriber);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(subscriber);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSubscriber(int id)
        {
            var subscriber = await _context.Subscribers.FindAsync(id);

            if (subscriber == null)
            {
                return NotFound();
            }

            return View(subscriber);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateSubscriber(Subscriber subscriber)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Subscribers.Update(subscriber);

                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {

                    ModelState.AddModelError("", "Lütfen tekrar deneyiniz!");
                }
            }
            return View(subscriber);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteSubscriber(int id)
        {
            var subscriber = await _context.Subscribers.FindAsync(id);

            if (subscriber == null)
            {
                return NotFound();
            }

            _context.Subscribers.Remove(subscriber);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}

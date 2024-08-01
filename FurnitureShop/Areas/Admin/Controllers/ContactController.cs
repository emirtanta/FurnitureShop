using FurnitureShop.Entities;
using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ContactController : Controller
    {
        private readonly FurnitureContext _context;

        public ContactController(FurnitureContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result=_context.ContactInfos.ToList();

            return View(result);
        }

        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(ContactInfo contactInfo)
        {
            if (ModelState.IsValid)
            {
                _context.ContactInfos.Add(contactInfo);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(contactInfo);
        }

        public async Task<IActionResult> UpdateContact(int id)
        {
            var contact=await _context.ContactInfos.FindAsync(id);

            if (contact==null)
            {
                return NotFound();
            }

            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateContact(ContactInfo Contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.ContactInfos.Update(Contact);

                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Lütfen Tekrar Deneyiniz.");
                }
            }
            return View(Contact);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var result = await _context.ContactInfos.FindAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            _context.ContactInfos.Remove(result);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
